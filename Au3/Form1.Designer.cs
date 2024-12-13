namespace Au3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtStackInput = new TextBox();
            txtStackOutput = new TextBox();
            btnPush = new Button();
            btnPop = new Button();
            txtQueueInput = new TextBox();
            txtQueueOutput = new TextBox();
            btnEnqueue = new Button();
            btnDequeue = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtStackInput
            // 
            txtStackInput.Location = new Point(76, 54);
            txtStackInput.Name = "txtStackInput";
            txtStackInput.Size = new Size(183, 23);
            txtStackInput.TabIndex = 0;
            // 
            // txtStackOutput
            // 
            txtStackOutput.Location = new Point(76, 241);
            txtStackOutput.Name = "txtStackOutput";
            txtStackOutput.Size = new Size(183, 23);
            txtStackOutput.TabIndex = 1;
            // 
            // btnPush
            // 
            btnPush.Location = new Point(76, 107);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(75, 23);
            btnPush.TabIndex = 2;
            btnPush.Text = "Push";
            btnPush.UseVisualStyleBackColor = true;
            btnPush.Click += btnPush_Click;
            // 
            // btnPop
            // 
            btnPop.Location = new Point(76, 176);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(75, 23);
            btnPop.TabIndex = 3;
            btnPop.Text = "Pop";
            btnPop.UseVisualStyleBackColor = true;
            btnPop.Click += btnPop_Click;
            // 
            // txtQueueInput
            // 
            txtQueueInput.Location = new Point(329, 54);
            txtQueueInput.Name = "txtQueueInput";
            txtQueueInput.Size = new Size(183, 23);
            txtQueueInput.TabIndex = 4;
            // 
            // txtQueueOutput
            // 
            txtQueueOutput.Location = new Point(329, 241);
            txtQueueOutput.Name = "txtQueueOutput";
            txtQueueOutput.Size = new Size(183, 23);
            txtQueueOutput.TabIndex = 5;
            // 
            // btnEnqueue
            // 
            btnEnqueue.Location = new Point(437, 107);
            btnEnqueue.Name = "btnEnqueue";
            btnEnqueue.Size = new Size(75, 23);
            btnEnqueue.TabIndex = 6;
            btnEnqueue.Text = "Enqueue";
            btnEnqueue.UseVisualStyleBackColor = true;
            btnEnqueue.Click += btnEnqueue_Click;
            // 
            // btnDequeue
            // 
            btnDequeue.Location = new Point(437, 176);
            btnDequeue.Name = "btnDequeue";
            btnDequeue.Size = new Size(75, 23);
            btnDequeue.TabIndex = 7;
            btnDequeue.Text = "Dequeue";
            btnDequeue.UseVisualStyleBackColor = true;
            btnDequeue.Click += btnDequeue_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 26);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 8;
            label1.Text = "Stack";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(442, 26);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 9;
            label2.Text = "Queue";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 337);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDequeue);
            Controls.Add(btnEnqueue);
            Controls.Add(txtQueueOutput);
            Controls.Add(txtQueueInput);
            Controls.Add(btnPop);
            Controls.Add(btnPush);
            Controls.Add(txtStackOutput);
            Controls.Add(txtStackInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStackInput;
        private TextBox txtStackOutput;
        private Button btnPush;
        private Button btnPop;
        private TextBox txtQueueInput;
        private TextBox txtQueueOutput;
        private Button btnEnqueue;
        private Button btnDequeue;
        private Label label1;
        private Label label2;
    }
}
