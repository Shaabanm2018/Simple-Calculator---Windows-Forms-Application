namespace basicCalculator
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
            UserInputText = new TextBox();
            CalculationResultText = new Label();
            ButtonPanel = new TableLayoutPanel();
            EqualButton = new Button();
            DotButton = new Button();
            ZeroButton = new Button();
            PluseMinuse = new Button();
            PluseButton = new Button();
            ThreeButton = new Button();
            TwoButton = new Button();
            OneButton = new Button();
            MinusButton = new Button();
            SixButton = new Button();
            FiveButton = new Button();
            FourButton = new Button();
            Xbutton = new Button();
            NineButton = new Button();
            EightButton = new Button();
            SevenButton = new Button();
            DivideButton = new Button();
            DelButton = new Button();
            CEButton = new Button();
            CButton = new Button();
            button1 = new Button();
            ButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // UserInputText
            // 
            UserInputText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UserInputText.Location = new Point(11, 32);
            UserInputText.Name = "UserInputText";
            UserInputText.Size = new Size(458, 25);
            UserInputText.TabIndex = 0;
            UserInputText.TextChanged += textBox1_TextChanged;
            // 
            // CalculationResultText
            // 
            CalculationResultText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CalculationResultText.Location = new Point(11, 63);
            CalculationResultText.Name = "CalculationResultText";
            CalculationResultText.Size = new Size(459, 47);
            CalculationResultText.TabIndex = 1;
            CalculationResultText.Text = "Please enter an equation and press enter or =";
            // 
            // ButtonPanel
            // 
            ButtonPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonPanel.ColumnCount = 4;
            ButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ButtonPanel.Controls.Add(EqualButton, 3, 4);
            ButtonPanel.Controls.Add(DotButton, 2, 4);
            ButtonPanel.Controls.Add(ZeroButton, 1, 4);
            ButtonPanel.Controls.Add(PluseMinuse, 0, 4);
            ButtonPanel.Controls.Add(PluseButton, 3, 3);
            ButtonPanel.Controls.Add(ThreeButton, 2, 3);
            ButtonPanel.Controls.Add(TwoButton, 1, 3);
            ButtonPanel.Controls.Add(OneButton, 0, 3);
            ButtonPanel.Controls.Add(MinusButton, 3, 2);
            ButtonPanel.Controls.Add(SixButton, 2, 2);
            ButtonPanel.Controls.Add(FiveButton, 1, 2);
            ButtonPanel.Controls.Add(FourButton, 0, 2);
            ButtonPanel.Controls.Add(Xbutton, 3, 1);
            ButtonPanel.Controls.Add(NineButton, 2, 1);
            ButtonPanel.Controls.Add(EightButton, 1, 1);
            ButtonPanel.Controls.Add(SevenButton, 0, 1);
            ButtonPanel.Controls.Add(DivideButton, 3, 0);
            ButtonPanel.Controls.Add(DelButton, 2, 0);
            ButtonPanel.Controls.Add(CEButton, 0, 0);
            ButtonPanel.Controls.Add(CButton, 1, 0);
            ButtonPanel.Location = new Point(2, 113);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.RowCount = 5;
            ButtonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            ButtonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            ButtonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            ButtonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            ButtonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            ButtonPanel.Size = new Size(479, 357);
            ButtonPanel.TabIndex = 2;
            ButtonPanel.Paint += tableLayoutPanel1_Paint;
            // 
            // EqualButton
            // 
            EqualButton.Dock = DockStyle.Fill;
            EqualButton.Location = new Point(360, 287);
            EqualButton.Name = "EqualButton";
            EqualButton.Size = new Size(116, 67);
            EqualButton.TabIndex = 19;
            EqualButton.Text = "=";
            EqualButton.UseVisualStyleBackColor = true;
            EqualButton.Click += EqualButton_Click;
            // 
            // DotButton
            // 
            DotButton.Dock = DockStyle.Fill;
            DotButton.Location = new Point(241, 287);
            DotButton.Name = "DotButton";
            DotButton.Size = new Size(113, 67);
            DotButton.TabIndex = 18;
            DotButton.Text = ".";
            DotButton.UseVisualStyleBackColor = true;
            DotButton.Click += DotButton_Click;
            // 
            // ZeroButton
            // 
            ZeroButton.Dock = DockStyle.Fill;
            ZeroButton.Location = new Point(122, 287);
            ZeroButton.Name = "ZeroButton";
            ZeroButton.Size = new Size(113, 67);
            ZeroButton.TabIndex = 17;
            ZeroButton.Text = "0";
            ZeroButton.UseVisualStyleBackColor = true;
            ZeroButton.Click += ZeroButton_Click;
            // 
            // PluseMinuse
            // 
            PluseMinuse.Dock = DockStyle.Fill;
            PluseMinuse.Location = new Point(3, 287);
            PluseMinuse.Name = "PluseMinuse";
            PluseMinuse.Size = new Size(113, 67);
            PluseMinuse.TabIndex = 16;
            PluseMinuse.Text = "+-";
            PluseMinuse.UseVisualStyleBackColor = true;
            // 
            // PluseButton
            // 
            PluseButton.Dock = DockStyle.Fill;
            PluseButton.Location = new Point(360, 216);
            PluseButton.Name = "PluseButton";
            PluseButton.Size = new Size(116, 65);
            PluseButton.TabIndex = 15;
            PluseButton.Text = "+";
            PluseButton.UseVisualStyleBackColor = true;
            PluseButton.Click += PluseButton_Click;
            // 
            // ThreeButton
            // 
            ThreeButton.Dock = DockStyle.Fill;
            ThreeButton.Location = new Point(241, 216);
            ThreeButton.Name = "ThreeButton";
            ThreeButton.Size = new Size(113, 65);
            ThreeButton.TabIndex = 14;
            ThreeButton.Text = "3";
            ThreeButton.UseVisualStyleBackColor = true;
            ThreeButton.Click += ThreeButton_Click;
            // 
            // TwoButton
            // 
            TwoButton.Dock = DockStyle.Fill;
            TwoButton.Location = new Point(122, 216);
            TwoButton.Name = "TwoButton";
            TwoButton.Size = new Size(113, 65);
            TwoButton.TabIndex = 13;
            TwoButton.Text = "2";
            TwoButton.UseVisualStyleBackColor = true;
            TwoButton.Click += TwoButton_Click;
            // 
            // OneButton
            // 
            OneButton.Dock = DockStyle.Fill;
            OneButton.Location = new Point(3, 216);
            OneButton.Name = "OneButton";
            OneButton.Size = new Size(113, 65);
            OneButton.TabIndex = 12;
            OneButton.Text = "1";
            OneButton.UseVisualStyleBackColor = true;
            OneButton.Click += OneButton_Click;
            // 
            // MinusButton
            // 
            MinusButton.Dock = DockStyle.Fill;
            MinusButton.Location = new Point(360, 145);
            MinusButton.Name = "MinusButton";
            MinusButton.Size = new Size(116, 65);
            MinusButton.TabIndex = 11;
            MinusButton.Text = "-";
            MinusButton.UseVisualStyleBackColor = true;
            MinusButton.Click += MinusButton_Click;
            // 
            // SixButton
            // 
            SixButton.Dock = DockStyle.Fill;
            SixButton.Location = new Point(241, 145);
            SixButton.Name = "SixButton";
            SixButton.Size = new Size(113, 65);
            SixButton.TabIndex = 10;
            SixButton.Text = "6";
            SixButton.UseVisualStyleBackColor = true;
            SixButton.Click += SixButton_Click;
            // 
            // FiveButton
            // 
            FiveButton.Dock = DockStyle.Fill;
            FiveButton.Location = new Point(122, 145);
            FiveButton.Name = "FiveButton";
            FiveButton.Size = new Size(113, 65);
            FiveButton.TabIndex = 9;
            FiveButton.Text = "5";
            FiveButton.UseVisualStyleBackColor = true;
            FiveButton.Click += FiveButton_Click;
            // 
            // FourButton
            // 
            FourButton.Dock = DockStyle.Fill;
            FourButton.Location = new Point(3, 145);
            FourButton.Name = "FourButton";
            FourButton.Size = new Size(113, 65);
            FourButton.TabIndex = 8;
            FourButton.Text = "4";
            FourButton.UseVisualStyleBackColor = true;
            FourButton.Click += FourButton_Click;
            // 
            // Xbutton
            // 
            Xbutton.Dock = DockStyle.Fill;
            Xbutton.Location = new Point(360, 74);
            Xbutton.Name = "Xbutton";
            Xbutton.Size = new Size(116, 65);
            Xbutton.TabIndex = 7;
            Xbutton.Text = "X";
            Xbutton.UseVisualStyleBackColor = true;
            Xbutton.Click += Xbutton_Click;
            // 
            // NineButton
            // 
            NineButton.Dock = DockStyle.Fill;
            NineButton.Location = new Point(241, 74);
            NineButton.Name = "NineButton";
            NineButton.Size = new Size(113, 65);
            NineButton.TabIndex = 6;
            NineButton.Text = "9";
            NineButton.UseVisualStyleBackColor = true;
            NineButton.Click += NineButton_Click;
            // 
            // EightButton
            // 
            EightButton.Dock = DockStyle.Fill;
            EightButton.Location = new Point(122, 74);
            EightButton.Name = "EightButton";
            EightButton.Size = new Size(113, 65);
            EightButton.TabIndex = 5;
            EightButton.Text = "8";
            EightButton.UseVisualStyleBackColor = true;
            EightButton.Click += EightButton_Click;
            // 
            // SevenButton
            // 
            SevenButton.Dock = DockStyle.Fill;
            SevenButton.Location = new Point(3, 74);
            SevenButton.Name = "SevenButton";
            SevenButton.Size = new Size(113, 65);
            SevenButton.TabIndex = 4;
            SevenButton.Text = "7";
            SevenButton.UseCompatibleTextRendering = true;
            SevenButton.UseVisualStyleBackColor = true;
            SevenButton.Click += SevenButton_Click;
            // 
            // DivideButton
            // 
            DivideButton.Dock = DockStyle.Fill;
            DivideButton.Location = new Point(360, 3);
            DivideButton.Name = "DivideButton";
            DivideButton.Size = new Size(116, 65);
            DivideButton.TabIndex = 3;
            DivideButton.Text = "%";
            DivideButton.UseVisualStyleBackColor = true;
            DivideButton.Click += DivideButton_Click;
            // 
            // DelButton
            // 
            DelButton.Dock = DockStyle.Fill;
            DelButton.Location = new Point(241, 3);
            DelButton.Name = "DelButton";
            DelButton.Size = new Size(113, 65);
            DelButton.TabIndex = 2;
            DelButton.Text = "Del";
            DelButton.UseVisualStyleBackColor = true;
            DelButton.Click += DelButton_Click;
            // 
            // CEButton
            // 
            CEButton.Dock = DockStyle.Fill;
            CEButton.Location = new Point(3, 3);
            CEButton.Name = "CEButton";
            CEButton.Size = new Size(113, 65);
            CEButton.TabIndex = 0;
            CEButton.Text = "CE";
            CEButton.UseVisualStyleBackColor = true;
            CEButton.Click += CButton_Click;
            // 
            // CButton
            // 
            CButton.Dock = DockStyle.Fill;
            CButton.Location = new Point(122, 3);
            CButton.Name = "CButton";
            CButton.Size = new Size(113, 65);
            CButton.TabIndex = 1;
            CButton.Text = "C";
            CButton.UseVisualStyleBackColor = true;
            CButton.Click += CButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(142, 90);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AcceptButton = EqualButton;
            CancelButton = CEButton;
            ClientSize = new Size(482, 473);
            Controls.Add(button1);
            Controls.Add(ButtonPanel);
            Controls.Add(CalculationResultText);
            Controls.Add(UserInputText);
            MaximumSize = new Size(500, 520);
            Name = "Form1";
            Text = "Basic Calculator ";
            Load += Form1_Load;
            ButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserInputText;
        private Label CalculationResultText;
        private TableLayoutPanel ButtonPanel;
        private Button CEButton;
        private Button EqualButton;
        private Button DotButton;
        private Button ZeroButton;
        private Button PluseMinuse;
        private Button PluseButton;
        private Button ThreeButton;
        private Button TwoButton;
        private Button OneButton;
        private Button MinusButton;
        private Button SixButton;
        private Button FiveButton;
        private Button FourButton;
        private Button Xbutton;
        private Button NineButton;
        private Button EightButton;
        private Button SevenButton;
        private Button DivideButton;
        private Button DelButton;
        private Button CButton;
        private Button button1;
    }
}
