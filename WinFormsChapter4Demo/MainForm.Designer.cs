namespace WinFormsChapter4Demo;

partial class MainForm
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
        crustGroupBox = new GroupBox();
        panRadioButton = new RadioButton();
        handTossedRadioButton = new RadioButton();
        thinCrustRadioButton = new RadioButton();
        toppingsGroupBox = new GroupBox();
        toppingsPeppersCheckBox = new CheckBox();
        toppingsMushroomsCheckBox = new CheckBox();
        toppingsSausageCheckBox = new CheckBox();
        toppingPepperoniCheckBox = new CheckBox();
        demoListBox = new ListBox();
        runButton = new Button();
        label1 = new Label();
        xTextBox = new TextBox();
        label2 = new Label();
        yTextBox = new TextBox();
        crustButton = new Button();
        crustLoopButton = new Button();
        toppingDemoButton = new Button();
        checkAllButton = new Button();
        clearListButton = new Button();
        lastChangedLabel = new Label();
        crustGroupBox.SuspendLayout();
        toppingsGroupBox.SuspendLayout();
        SuspendLayout();
        // 
        // crustGroupBox
        // 
        crustGroupBox.Controls.Add(panRadioButton);
        crustGroupBox.Controls.Add(handTossedRadioButton);
        crustGroupBox.Controls.Add(thinCrustRadioButton);
        crustGroupBox.Location = new Point(371, 12);
        crustGroupBox.Name = "crustGroupBox";
        crustGroupBox.Size = new Size(175, 148);
        crustGroupBox.TabIndex = 0;
        crustGroupBox.TabStop = false;
        crustGroupBox.Text = "Pizza &Crust";
        // 
        // panRadioButton
        // 
        panRadioButton.AutoSize = true;
        panRadioButton.Location = new Point(18, 96);
        panRadioButton.Name = "panRadioButton";
        panRadioButton.Size = new Size(53, 24);
        panRadioButton.TabIndex = 2;
        panRadioButton.TabStop = true;
        panRadioButton.Text = "Pan";
        panRadioButton.UseVisualStyleBackColor = true;
        panRadioButton.CheckedChanged += panRadioButton_CheckedChanged;
        // 
        // handTossedRadioButton
        // 
        handTossedRadioButton.AutoSize = true;
        handTossedRadioButton.Location = new Point(18, 66);
        handTossedRadioButton.Name = "handTossedRadioButton";
        handTossedRadioButton.Size = new Size(115, 24);
        handTossedRadioButton.TabIndex = 1;
        handTossedRadioButton.TabStop = true;
        handTossedRadioButton.Text = "&Hand Tossed";
        handTossedRadioButton.UseVisualStyleBackColor = true;
        handTossedRadioButton.CheckedChanged += handTossedRadioButton_CheckedChanged;
        // 
        // thinCrustRadioButton
        // 
        thinCrustRadioButton.AutoSize = true;
        thinCrustRadioButton.Location = new Point(18, 36);
        thinCrustRadioButton.Name = "thinCrustRadioButton";
        thinCrustRadioButton.Size = new Size(95, 24);
        thinCrustRadioButton.TabIndex = 0;
        thinCrustRadioButton.TabStop = true;
        thinCrustRadioButton.Text = "Thin Crust";
        thinCrustRadioButton.UseVisualStyleBackColor = true;
        thinCrustRadioButton.CheckedChanged += thinCrustRadioButton_CheckedChanged;
        // 
        // toppingsGroupBox
        // 
        toppingsGroupBox.Controls.Add(toppingsPeppersCheckBox);
        toppingsGroupBox.Controls.Add(toppingsMushroomsCheckBox);
        toppingsGroupBox.Controls.Add(toppingsSausageCheckBox);
        toppingsGroupBox.Controls.Add(toppingPepperoniCheckBox);
        toppingsGroupBox.Location = new Point(642, 12);
        toppingsGroupBox.Name = "toppingsGroupBox";
        toppingsGroupBox.Size = new Size(175, 188);
        toppingsGroupBox.TabIndex = 1;
        toppingsGroupBox.TabStop = false;
        toppingsGroupBox.Text = "Pizza &Toppings";
        // 
        // toppingsPeppersCheckBox
        // 
        toppingsPeppersCheckBox.AutoSize = true;
        toppingsPeppersCheckBox.Location = new Point(17, 127);
        toppingsPeppersCheckBox.Name = "toppingsPeppersCheckBox";
        toppingsPeppersCheckBox.Size = new Size(83, 24);
        toppingsPeppersCheckBox.TabIndex = 3;
        toppingsPeppersCheckBox.Text = "Peppers";
        toppingsPeppersCheckBox.UseVisualStyleBackColor = true;
        toppingsPeppersCheckBox.CheckedChanged += toppingsPeppersCheckBox_CheckedChanged;
        // 
        // toppingsMushroomsCheckBox
        // 
        toppingsMushroomsCheckBox.AutoSize = true;
        toppingsMushroomsCheckBox.Location = new Point(17, 97);
        toppingsMushroomsCheckBox.Name = "toppingsMushroomsCheckBox";
        toppingsMushroomsCheckBox.Size = new Size(108, 24);
        toppingsMushroomsCheckBox.TabIndex = 2;
        toppingsMushroomsCheckBox.Text = "Mushrooms";
        toppingsMushroomsCheckBox.UseVisualStyleBackColor = true;
        toppingsMushroomsCheckBox.CheckedChanged += toppingsMushroomsCheckBox_CheckedChanged;
        // 
        // toppingsSausageCheckBox
        // 
        toppingsSausageCheckBox.AutoSize = true;
        toppingsSausageCheckBox.Location = new Point(17, 66);
        toppingsSausageCheckBox.Name = "toppingsSausageCheckBox";
        toppingsSausageCheckBox.Size = new Size(86, 24);
        toppingsSausageCheckBox.TabIndex = 1;
        toppingsSausageCheckBox.Text = "Sausage";
        toppingsSausageCheckBox.UseVisualStyleBackColor = true;
        toppingsSausageCheckBox.CheckedChanged += toppingsSausageCheckBox_CheckedChanged;
        // 
        // toppingPepperoniCheckBox
        // 
        toppingPepperoniCheckBox.AutoSize = true;
        toppingPepperoniCheckBox.Location = new Point(17, 37);
        toppingPepperoniCheckBox.Name = "toppingPepperoniCheckBox";
        toppingPepperoniCheckBox.Size = new Size(98, 24);
        toppingPepperoniCheckBox.TabIndex = 0;
        toppingPepperoniCheckBox.Text = "&Pepperoni";
        toppingPepperoniCheckBox.UseVisualStyleBackColor = true;
        toppingPepperoniCheckBox.CheckedChanged += toppingPepperoniCheckBox_CheckedChanged;
        // 
        // demoListBox
        // 
        demoListBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        demoListBox.FormattingEnabled = true;
        demoListBox.ItemHeight = 31;
        demoListBox.Items.AddRange(new object[] { "BasicIfSyntaxDemo1", "BasicIfSyntaxDemo2", "BasicIfSyntaxDemo3", "BasicIfSyntaxDemo4", "BasicIfSyntaxDemo5", "ShortCircuitDemo", "StringCompareDemo1", "StringCompareDemo2", "StringCompareDemo3", "DefaultParamValueDemo", "RefParamDemo", "OutParamDemo", "ReturnDemo" });
        demoListBox.Location = new Point(12, 12);
        demoListBox.Name = "demoListBox";
        demoListBox.Size = new Size(250, 314);
        demoListBox.TabIndex = 2;
        // 
        // runButton
        // 
        runButton.Location = new Point(12, 440);
        runButton.Name = "runButton";
        runButton.Size = new Size(250, 29);
        runButton.TabIndex = 3;
        runButton.Text = "&Run Demo";
        runButton.UseVisualStyleBackColor = true;
        runButton.Click += runButton_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 345);
        label1.Name = "label1";
        label1.Size = new Size(21, 20);
        label1.TabIndex = 4;
        label1.Text = "&X:";
        // 
        // xTextBox
        // 
        xTextBox.Location = new Point(39, 345);
        xTextBox.Name = "xTextBox";
        xTextBox.Size = new Size(223, 27);
        xTextBox.TabIndex = 5;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 390);
        label2.Name = "label2";
        label2.Size = new Size(20, 20);
        label2.TabIndex = 6;
        label2.Text = "&Y:";
        // 
        // yTextBox
        // 
        yTextBox.Location = new Point(42, 392);
        yTextBox.Name = "yTextBox";
        yTextBox.Size = new Size(220, 27);
        yTextBox.TabIndex = 7;
        // 
        // crustButton
        // 
        crustButton.Location = new Point(373, 171);
        crustButton.Name = "crustButton";
        crustButton.Size = new Size(173, 29);
        crustButton.TabIndex = 8;
        crustButton.Text = "&Crust Demo";
        crustButton.UseVisualStyleBackColor = true;
        crustButton.Click += crustButton_Click;
        // 
        // crustLoopButton
        // 
        crustLoopButton.Location = new Point(375, 217);
        crustLoopButton.Name = "crustLoopButton";
        crustLoopButton.Size = new Size(171, 29);
        crustLoopButton.TabIndex = 9;
        crustLoopButton.Text = "&Crust Loop Demo";
        crustLoopButton.UseVisualStyleBackColor = true;
        crustLoopButton.Click += crustLoopButton_Click;
        // 
        // toppingDemoButton
        // 
        toppingDemoButton.Location = new Point(642, 217);
        toppingDemoButton.Name = "toppingDemoButton";
        toppingDemoButton.Size = new Size(175, 29);
        toppingDemoButton.TabIndex = 10;
        toppingDemoButton.Text = "Checkbox Demo";
        toppingDemoButton.UseVisualStyleBackColor = true;
        toppingDemoButton.Click += toppingDemoButton_Click;
        // 
        // checkAllButton
        // 
        checkAllButton.Location = new Point(642, 264);
        checkAllButton.Name = "checkAllButton";
        checkAllButton.Size = new Size(175, 29);
        checkAllButton.TabIndex = 11;
        checkAllButton.Text = "Make it supreme!";
        checkAllButton.UseVisualStyleBackColor = true;
        checkAllButton.Click += checkAllButton_Click;
        // 
        // clearListButton
        // 
        clearListButton.Location = new Point(12, 491);
        clearListButton.Name = "clearListButton";
        clearListButton.Size = new Size(250, 29);
        clearListButton.TabIndex = 12;
        clearListButton.Text = "Press Me Last";
        clearListButton.UseVisualStyleBackColor = true;
        clearListButton.Click += clearListButton_Click;
        // 
        // lastChangedLabel
        // 
        lastChangedLabel.BorderStyle = BorderStyle.FixedSingle;
        lastChangedLabel.Location = new Point(375, 328);
        lastChangedLabel.Name = "lastChangedLabel";
        lastChangedLabel.Size = new Size(442, 67);
        lastChangedLabel.TabIndex = 13;
        lastChangedLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(888, 559);
        Controls.Add(lastChangedLabel);
        Controls.Add(clearListButton);
        Controls.Add(checkAllButton);
        Controls.Add(toppingDemoButton);
        Controls.Add(crustLoopButton);
        Controls.Add(crustButton);
        Controls.Add(yTextBox);
        Controls.Add(label2);
        Controls.Add(xTextBox);
        Controls.Add(label1);
        Controls.Add(runButton);
        Controls.Add(demoListBox);
        Controls.Add(toppingsGroupBox);
        Controls.Add(crustGroupBox);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "MainForm";
        Text = "Chapter 4 Demo";
        Load += MainForm_Load;
        crustGroupBox.ResumeLayout(false);
        crustGroupBox.PerformLayout();
        toppingsGroupBox.ResumeLayout(false);
        toppingsGroupBox.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private GroupBox crustGroupBox;
    private RadioButton panRadioButton;
    private RadioButton handTossedRadioButton;
    private RadioButton thinCrustRadioButton;
    private GroupBox toppingsGroupBox;
    private CheckBox toppingsPeppersCheckBox;
    private CheckBox toppingsMushroomsCheckBox;
    private CheckBox toppingsSausageCheckBox;
    private CheckBox toppingPepperoniCheckBox;
    private ListBox demoListBox;
    private Button runButton;
    private Label label1;
    private TextBox xTextBox;
    private Label label2;
    private TextBox yTextBox;
    private Button crustButton;
    private Button crustLoopButton;
    private Button toppingDemoButton;
    private Button checkAllButton;
    private Button clearListButton;
    private Label lastChangedLabel;
}
