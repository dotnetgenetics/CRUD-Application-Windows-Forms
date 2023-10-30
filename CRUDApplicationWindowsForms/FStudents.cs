using CRUDApplicationWindowsForms.DataAccess;
using CRUDApplicationWindowsForms.Model;

namespace CRUDApplicationWindowsForms
{
   public partial class FStudents : Form
   {
      private Student student;
      private int ID { get; set; }
      private StudentService service;

      public FStudents()
      {
         InitializeComponent();
      }

      private void FStudents_Load(object sender, EventArgs e)
      {
         FetchData();
      }

      private void FetchData()
      {
         service = new StudentService();
         dgvStudents.DataSource = service.Fetch();
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         student = new Student();

         if (ID <= 0) //perform saving
         {
            if ((txtName.Text != string.Empty))
            {
               student.Name = txtName.Text;
               student.Address = txtAddress.Text;
               student.Age = string.IsNullOrEmpty(txtAge.Text) ? 0 : Convert.ToInt32(txtAge.Text);
               student.Contact = txtContact.Text;
               service.SaveStudent(student);
            }
            else
            {
               MessageBox.Show("Add at least a value to name!", "Add value", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }
         else //perform updating
         {
            student.ID = ID;
            student.Name = txtName.Text;
            student.Address = txtAddress.Text;
            student.Age = string.IsNullOrEmpty(txtAge.Text) ? 0 : Convert.ToInt32(txtAge.Text);
            student.Contact = txtContact.Text;
            service.UpdateStudent(student);
         }

         ClearControls();
         ResetID();
         FetchData();
      }

      private void btnCancel_Click(object sender, EventArgs e)
      {
         ClearControls();
         ResetID();
      }

      private void ClearControls()
      {
         txtAddress.Text = string.Empty;
         txtAge.Text = string.Empty;
         txtContact.Text = string.Empty;
         txtName.Text = string.Empty;
      }

      private void ResetID()
      {
         ID = -1;
      }

      private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {
         //Delete column has index 1
         if (e.RowIndex >= 0 && ((DataGridView)sender).Columns[e.ColumnIndex].GetType() == typeof(DataGridViewButtonColumn) && (e.ColumnIndex == 1))
         {
            if (MessageBox.Show("You sure about this? Student will be deleted from database!", "Remove?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
               if (((DataGridView)sender).CurrentRow.Cells[2].Value != null)
               {
                  student = new Student();
                  student.ID = Convert.ToInt32(((DataGridView)sender).CurrentRow.Cells[2].Value);
                  service.DeleteStudent(student);
                  FetchData(); //update grid and database
               }
            }
         }
         else
         {
            //edit button has column index 0
            if (e.RowIndex >= 0 && ((DataGridView)sender).Columns[e.ColumnIndex].GetType() == typeof(DataGridViewButtonColumn) && (e.ColumnIndex == 0))
            {
               ID = Convert.ToInt32(((DataGridView)sender).CurrentRow.Cells[2].Value); //ID column in datagrid has column index of 2
               txtAddress.Text = ((DataGridView)sender).CurrentRow.Cells[5].Value.ToString();
               txtAge.Text = ((DataGridView)sender).CurrentRow.Cells[4].Value.ToString();
               txtContact.Text = ((DataGridView)sender).CurrentRow.Cells[6].Value.ToString();
               txtName.Text = ((DataGridView)sender).CurrentRow.Cells[3].Value.ToString();
            }
         }
      }
   }
}