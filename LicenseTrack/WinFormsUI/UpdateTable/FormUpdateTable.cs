using Business.Concrete;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsUI.ProgramLicense;

namespace WinFormsUI.UpdateTable
{
    public partial class FormUpdateTable : Form
    {
        UpdateTableManager updateTableManager = new UpdateTableManager(new EfUpdateTableDal());
        public FormUpdateTable()
        {
            InitializeComponent();
            this.Load += FormUpdateTable_Load;
        }

        private void FormUpdateTable_Load(object sender, EventArgs e)
        {
            try
            {
                var updates = updateTableManager.GetAll();
                dgwUpdateTable.DataSource = updates;

                if (updates.Count == 0)
                {
                    MessageBox.Show("Veritabanında lisans bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormUpdateTableDetails form = new FormUpdateTableDetails();
            if (form.ShowDialog() == DialogResult.OK)
            {
                dgwUpdateTable.DataSource = updateTableManager.GetAll();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dgwUpdateTable.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellemek için bir program seçin.");
                return;
            }
            Entities.Concrete.UpdateTable selectedUpdate = (Entities.Concrete.UpdateTable)dgwUpdateTable.CurrentRow.DataBoundItem;
            FormUpdateTableDetails form = new FormUpdateTableDetails(selectedUpdate);
            if (form.ShowDialog() == DialogResult.OK)
            {
                dgwUpdateTable.DataSource = updateTableManager.GetAll();
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dgwUpdateTable.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellemek için bir program seçin.");
                return;
            }
            Entities.Concrete.UpdateTable selectedUpdate = (Entities.Concrete.UpdateTable)dgwUpdateTable.CurrentRow.DataBoundItem;
            DialogResult dialogResult = MessageBox.Show(
                $"{selectedUpdate.UpdateID} numaralı programı silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                updateTableManager.Delete(selectedUpdate);
                MessageBox.Show("Program başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgwUpdateTable.DataSource = updateTableManager.GetAll();
            }

        }
    }
}
