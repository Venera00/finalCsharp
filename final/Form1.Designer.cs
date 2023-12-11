
namespace YourNamespace
{
    partial class TaskManagerForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.taskNameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.deadlineDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.ItemHeight = 16;
            this.listBoxTasks.Location = new System.Drawing.Point(20, 20);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(200, 292);
            this.listBoxTasks.TabIndex = 0;
            // 
            // taskNameTextBox
            // 
            this.taskNameTextBox.Location = new System.Drawing.Point(250, 20);
            this.taskNameTextBox.Name = "taskNameTextBox";
            this.taskNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.taskNameTextBox.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(250, 60);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 22);
            this.descriptionTextBox.TabIndex = 2;
            // 
            // deadlineDateTimePicker
            // 
            this.deadlineDateTimePicker.Location = new System.Drawing.Point(250, 180);
            this.deadlineDateTimePicker.Name = "deadlineDateTimePicker";
            this.deadlineDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.deadlineDateTimePicker.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(250, 220);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 30);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(330, 220);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 30);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Edit";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(410, 220);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 30);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            // 
            // TaskManagerForm
            // 
            this.ClientSize = new System.Drawing.Size(758, 428);
            this.Controls.Add(this.listBoxTasks);
            this.Controls.Add(this.taskNameTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.deadlineDateTimePicker);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Name = "TaskManagerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

