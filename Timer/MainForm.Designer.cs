
namespace Timer
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startStopButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.minutesUpDown = new System.Windows.Forms.NumericUpDown();
            this.secondsUpDown = new System.Windows.Forms.NumericUpDown();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.hoursUpDown = new System.Windows.Forms.NumericUpDown();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timerProgressBar = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.onTopCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.minutesUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursUpDown)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // startStopButton
            // 
            this.startStopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startStopButton.Location = new System.Drawing.Point(3, 41);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(112, 24);
            this.startStopButton.TabIndex = 0;
            this.startStopButton.Text = "Start / Stop";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetButton.Location = new System.Drawing.Point(3, 71);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(112, 24);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // minutesUpDown
            // 
            this.minutesUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.minutesUpDown.Location = new System.Drawing.Point(102, 5);
            this.minutesUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesUpDown.Name = "minutesUpDown";
            this.minutesUpDown.Size = new System.Drawing.Size(94, 20);
            this.minutesUpDown.TabIndex = 1;
            this.minutesUpDown.ValueChanged += new System.EventHandler(this.minutesUpDown_ValueChanged);
            // 
            // secondsUpDown
            // 
            this.secondsUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.secondsUpDown.Location = new System.Drawing.Point(202, 5);
            this.secondsUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondsUpDown.Name = "secondsUpDown";
            this.secondsUpDown.Size = new System.Drawing.Size(95, 20);
            this.secondsUpDown.TabIndex = 2;
            this.secondsUpDown.ValueChanged += new System.EventHandler(this.secondsUpDown_ValueChanged);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // hoursUpDown
            // 
            this.hoursUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.hoursUpDown.Location = new System.Drawing.Point(3, 5);
            this.hoursUpDown.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.hoursUpDown.Name = "hoursUpDown";
            this.hoursUpDown.Size = new System.Drawing.Size(93, 20);
            this.hoursUpDown.TabIndex = 0;
            this.hoursUpDown.ValueChanged += new System.EventHandler(this.hoursUpDown_ValueChanged);
            // 
            // timerLabel
            // 
            this.timerLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timerLabel.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.timerLabel, 3);
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(8, 47);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(284, 73);
            this.timerLabel.TabIndex = 3;
            this.timerLabel.Text = "00:00:00";
            // 
            // timerProgressBar
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.timerProgressBar, 3);
            this.timerProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timerProgressBar.Location = new System.Drawing.Point(3, 140);
            this.timerProgressBar.Name = "timerProgressBar";
            this.timerProgressBar.Size = new System.Drawing.Size(294, 24);
            this.timerProgressBar.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 211);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.timerProgressBar, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.secondsUpDown, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.hoursUpDown, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.minutesUpDown, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.timerLabel, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(22, 22);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(300, 167);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.startStopButton, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.resetButton, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.onTopCheckBox, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(344, 22);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(118, 167);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // onTopCheckBox
            // 
            this.onTopCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.onTopCheckBox.AutoSize = true;
            this.onTopCheckBox.Checked = true;
            this.onTopCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.onTopCheckBox.Location = new System.Drawing.Point(3, 104);
            this.onTopCheckBox.Name = "onTopCheckBox";
            this.onTopCheckBox.Size = new System.Drawing.Size(92, 17);
            this.onTopCheckBox.TabIndex = 2;
            this.onTopCheckBox.Text = "Always on top";
            this.onTopCheckBox.UseVisualStyleBackColor = true;
            this.onTopCheckBox.CheckedChanged += new System.EventHandler(this.onTopCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Timer";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.minutesUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursUpDown)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.NumericUpDown minutesUpDown;
        private System.Windows.Forms.NumericUpDown secondsUpDown;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NumericUpDown hoursUpDown;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.ProgressBar timerProgressBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox onTopCheckBox;
    }
}

