using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Firebase.Database;
using Firebase.Database.Query;

using System.Reactive.Linq;
using DrCare.Constants;

using DrCare.EL;
using FirebaseLipstick.EL;

using DrCare.PL;

namespace FirebaseLipstick
{
    public partial class FormMedRec : Form
    {
        private const String FIREBASE_APP = "https://drcareandroid.firebaseio.com/";

        private FirebaseClient firebase;

        String CurrentKey;

        int nextSTT;

        MedicalRecord CURRENT_MED_REC;

        List<User> userList;

        List<MedicalRecord> medicalRecords;

        public FormMedRec()
        {
            InitializeComponent();

            InitFirebase();

            
            ListenFirebase();

        }        

        private void InitFirebase()
        {
            firebase = new FirebaseClient(FIREBASE_APP);
        }

        private void ListenFirebase() {
            firebase.Child(Constants.MEDICAL_RECORDS_CHILD).AsObservable<MedicalRecord>().Subscribe(async item =>
            {
                List<MedicalRecord> records = new List<MedicalRecord>();
                List<MedicalRecordNode> nodes = await LoadAll();

                foreach (MedicalRecordNode node in nodes)
                {
                    node.medicalRecord.Key = node.MedRecKey;
                    node.medicalRecord.PatientName = await get_userName_by_Key(node.medicalRecord.PatientKey);
                    node.medicalRecord.DoctorName = await get_userName_by_Key(node.medicalRecord.DoctorKey);
                    //new UserBUS().getUserNamedByKey(node.medicalRecord.DoctorKey, node.medicalRecord.PatientKey, node.medicalRecord);
                    records.Add(node.medicalRecord);

                }

                nextSTT = records.Count() + 2;

                setupDataGrid(records);
                
            });

        }

        private void setupDataGrid(List<MedicalRecord> records)
        {
            dataGridMedRec.BeginInvoke(new MethodInvoker(delegate
            {
                dataGridMedRec.DataSource = records;
                dataGridMedRec.Visible = true;
                dataGridMedRec.Refresh();

                dataGridMedRec.Columns["Key"].Visible = false;

                dataGridMedRec.Columns["Stt"].HeaderText = "Stt";
                dataGridMedRec.Columns["Stt"].ReadOnly = true;

                dataGridMedRec.Columns["DoctorKey"].Visible = false;
                dataGridMedRec.Columns["PatientKey"].Visible = false;

                dataGridMedRec.Columns["DayCreated"].HeaderText = "Day Created";
                dataGridMedRec.Columns["DayCreated"].ReadOnly = true;

                dataGridMedRec.Columns["medRecNote"].HeaderText = "Note";
                dataGridMedRec.Columns["medRecNote"].ReadOnly = true;

            }));
        }

        private async Task<List<MedicalRecordNode>> LoadAll()
        {
            List<MedicalRecordNode> listNodes = new List<MedicalRecordNode>();

            var firebaseObjects = await firebase.Child(Constants.MEDICAL_RECORDS_CHILD).OnceAsync<MedicalRecord>();

            foreach (var item in firebaseObjects)
            {
                MedicalRecordNode node = new MedicalRecordNode(item.Key, item.Object);
                listNodes.Add(node);
            }
            return listNodes;
        }

        private void dataGridLipstick_SelectedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridMedRec.SelectedRows)
            {
                //CURRENT_MED_REC = new MedicalRecord()
                //{
                //    Key = row.Cells[0].Value.ToString(),
                //    isTaken = Int32.Parse(row.Cells[1].Value.ToString()),
                //    DoctorKey = row.Cells[3].Value.ToString(),
                //    PatientKey = row.Cells[4].Value.ToString(),
                //    DiseaseName = row.Cells[7].Value.ToString(),
                //    DayCreated = DateTime.Now.ToShortDateString(),
                //    medRecNote = " "
                //};

                //take ID to update/ delete
                CurrentKey = row.Cells[0].Value.ToString();

                labelStt.Text = row.Cells[1].Value.ToString();

                txtPatientName.Text = row.Cells[6].Value.ToString();
                //txtSpecial.Text = row.Cells[6].Value.ToString();
                txtDoctorName.Text = row.Cells[5].Value.ToString();
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPatientName.Text = "";
            txtSpecial.Text = "";
            txtDoctorName.Text = "";
            labelStt.Text = nextSTT.ToString() ;

            labelDate.Text = "Today: " + DateTime.Now.ToShortDateString();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            preExecute();

            MedicalRecord record = new MedicalRecord()
            {
                Stt = nextSTT,
                isTaken = 0,
                DayCreated = DateTime.Now.ToShortDateString(),
                PatientKey = await get_userKey_ByName(txtPatientName.Text),
                DoctorKey = await get_userKey_ByName(txtDoctorName.Text), /// TODO: get DoctorKey => add to MedRec
                DiseaseName = "",
                medRecNote = "",
            };
            
            var node = firebase.Child("medicalRecords").PostAsync(record);
                    
            onPostExecution((node != null) ? true : false);
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            preExecute();

            //MedicalRecord record = new MedicalRecord()
            //{
            //    isTaken = 0,
            //    DayCreated = DateTime.Now.ToShortDateString(),
            //    PatientKey = new UserBUS().GetKeydByUsername(txtPatientName.Text, userList).Key,
            //    DoctorKey = new UserBUS().GetKeydByUsername(txtDoctorName.Text, userList).Key, /// TODO: get DoctorKey => add to MedRec
            //    Key = CurrentKey,
            //    Stt = 
            //};

            MedicalRecordNode record = await getMedicalRecordByKey(CurrentKey);

            //record.medicalRecord.PatientKey = //FormUser. ;//get key form parent activity
            record.medicalRecord.DoctorKey = await get_userKey_ByName(txtDoctorName.Text);

            DialogResult result = MessageBox.Show("Switch status? \n (Waiting <=> Done)", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if(record.medicalRecord.isTaken == 0)
                    record.medicalRecord.isTaken = 1;
                else
                {
                    record.medicalRecord.DiseaseName = " ";
                    record.medicalRecord.isTaken = 0;
                }
                try {
                    await firebase.Child(Constants.MEDICAL_RECORDS_CHILD).Child(CurrentKey).PutAsync(record.medicalRecord);
                    onPostExecution(true);
                }
                catch (Exception ex)
                {
                    onPostExecution(false, ex.Message);
                }
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            preExecute();

            DialogResult result = MessageBox.Show("Sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try {
                    await firebase.Child(Constants.MEDICAL_RECORDS_CHILD).Child(CurrentKey).DeleteAsync();
                    onPostExecution(true);
                }
                catch (Exception ex)
                {
                    onPostExecution(false, ex.Message);
                }            
            }

        }

        private async Task<MedicalRecordNode> getMedicalRecordByKey(String key)
        {
            var firebaseObj = await firebase.Child(Constants.MEDICAL_RECORDS_CHILD).OnceAsync<MedicalRecord>();
            foreach (var item in firebaseObj)
                if (item.Key == key)
                    return new MedicalRecordNode(item.Key, item.Object);
            return null;
        }

        private async Task<String> get_userKey_ByName(String inputName)
        {
            var firebaseObj = await firebase.Child(Constants.USER_CHILD).OnceAsync<User>();
            foreach (var item in firebaseObj)
                if (item.Object.UserName.Equals(inputName))
                    return item.Key;
            return null;
        }

        private async Task<String> get_userName_by_Key(String key)
        {
            var firebaseObj = await firebase.Child(Constants.USER_CHILD).OnceAsync<User>();
            foreach (var item in firebaseObj)
                if (item.Key == key)
                    return item.Object.UserName;
            return null;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            preExecute();

            List<MedicalRecordNode> nodes = await SearchByName(txtSearch.Text);
            List<MedicalRecord> records = new List<MedicalRecord>();

            foreach (MedicalRecordNode node in nodes)
            {
                records.Add(node.medicalRecord);
            }

            //LoadDataGridView(records);
        }

        private async Task<List<MedicalRecordNode>> SearchByName(string input)
        {
            List<MedicalRecordNode> listNodes = new List<MedicalRecordNode>();

            var firebaseObjects = await firebase.Child("lipstick").OnceAsync<MedicalRecord>();

            foreach (var item in firebaseObjects)
            {
                MedicalRecordNode node = new MedicalRecordNode(item.Key, item.Object);
                if (node.medicalRecord.PatientKey.Contains(input)) //todo: get PATIENT KEY by Patient Name
                    listNodes.Add(node);
            }

            return listNodes;
        }

        private void preExecute()
        {
            txtLoading.Visible = true;
            dataGridMedRec.Visible = false;
        }


        private void onPostExecution(bool isSuccess, string message ="Không nhích được!")
        {
            if (isSuccess)
            {
                MessageBox.Show("Tới luôn!");
            }
            else
            {
                if(message != null)
                    MessageBox.Show(message);
            };
        }

        private async void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            //dataGridLipstick.DataSource = new api().Search(txtSearch.Text);

            txtLoading.Visible = true;
            dataGridMedRec.Visible = false;

            List<MedicalRecordNode> nodes = await SearchByName(txtSearch.Text);
            List<MedicalRecord> records = new List<MedicalRecord>();

            foreach (MedicalRecordNode node in nodes)
            {
                records.Add(node.medicalRecord);
            }

            //LoadDataGridView(records);
        }

    }
}
