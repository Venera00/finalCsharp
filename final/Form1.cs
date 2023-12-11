using System;
using System.Windows.Forms;

namespace YourNamespace
{
    public partial class TaskManagerForm : Form
    {
        private ListBox listBoxTasks;
        private TextBox taskNameTextBox;
        private TextBox descriptionTextBox;
        private DateTimePicker deadlineDateTimePicker;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;

        public TaskManagerForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            

            // Example: Initialize controls with their properties and add them to the form
            listBoxTasks = new ListBox();
            listBoxTasks.Location = new System.Drawing.Point(20, 20);
            listBoxTasks.Size = new System.Drawing.Size(200, 300);
            Controls.Add(listBoxTasks);

            taskNameTextBox = new TextBox();
            taskNameTextBox.Location = new System.Drawing.Point(250, 20);
            taskNameTextBox.Size = new System.Drawing.Size(200, 20);
            Controls.Add(taskNameTextBox);

            descriptionTextBox = new TextBox();
            descriptionTextBox.Location = new System.Drawing.Point(250, 60);
            descriptionTextBox.Size = new System.Drawing.Size(200, 100);
            Controls.Add(descriptionTextBox);

            deadlineDateTimePicker = new DateTimePicker();
            deadlineDateTimePicker.Location = new System.Drawing.Point(250, 180);
            deadlineDateTimePicker.Size = new System.Drawing.Size(200, 20);
            Controls.Add(deadlineDateTimePicker);

            addButton = new Button();
            addButton.Text = "Add";
            addButton.Location = new System.Drawing.Point(250, 220);
            addButton.Size = new System.Drawing.Size(75, 30);
            addButton.Click += addButton_Click;
            Controls.Add(addButton);

            editButton = new Button();
            editButton.Text = "Edit";
            editButton.Location = new System.Drawing.Point(330, 220);
            editButton.Size = new System.Drawing.Size(75, 30);
            editButton.Click += editButton_Click;
            Controls.Add(editButton);

            deleteButton = new Button();
            deleteButton.Text = "Delete";
            deleteButton.Location = new System.Drawing.Point(410, 220);
            deleteButton.Size = new System.Drawing.Size(75, 30);
            deleteButton.Click += deleteButton_Click;
            Controls.Add(deleteButton);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string taskName = taskNameTextBox.Text;
            string description = descriptionTextBox.Text;
            DateTime deadline = deadlineDateTimePicker.Value;

            
            listBoxTasks.Items.Add($"{taskName} - Due: {deadline.ToShortDateString()}");
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex >= 0)
            {
                string taskName = taskNameTextBox.Text;
                string description = descriptionTextBox.Text;
                DateTime deadline = deadlineDateTimePicker.Value;

                // Update the selected task in the list
                listBoxTasks.Items[listBoxTasks.SelectedIndex] = $"{taskName} - Due: {deadline.ToShortDateString()}";
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex >= 0)
            {
                // Delete the selected task from the list
                listBoxTasks.Items.RemoveAt(listBoxTasks.SelectedIndex);
            }
        }

        private void taskNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
