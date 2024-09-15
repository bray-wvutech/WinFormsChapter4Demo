namespace WinFormsChapter4Demo;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
    }

    private void DefaultParamValue(int x = 0)
    {
        MessageBox.Show(x.ToString());
    }

    private void DefaultParamValueDemo()
    {
        DefaultParamValue(3);
        DefaultParamValue();
    }

    private void RefParamFunc(ref int rp)
    {
        // doesn't have to be set
        // if we comment this out everything still compiles
        rp = 3;
    }

    private void RefParamDemo()
    {
        int x = 4;
        // does have to be initialized
        //int x;
        MessageBox.Show(x.ToString());
        RefParamFunc(ref x);
        MessageBox.Show(x.ToString());
    }

    private void OutParamFunc(out int op)
    {
        // does have to be set before returning
        // if we comment this out we will get an error
        op = 30;
    }

    private void OutParamDemo()
    {
        int x = 40;
        // doesn't have to be initialized
        //int x;
        MessageBox.Show(x.ToString());
        OutParamFunc(out x);
        MessageBox.Show(x.ToString());
    }

    private bool IsEvenNumber(int x)
    {
        return x % 2 == 0;
    }

    private int GetNumber()
    {
        return 1;
    }

    private void ReturnDemo()
    {
        int x = GetNumber();

        if (IsEvenNumber(x))
        {
            MessageBox.Show($"{x} is even");
        }
        else
        {
            MessageBox.Show($"{x} is odd");
        }
    }


    private void BasicIfSyntaxDemo1(int x, int y)
    {
        // basic syntax
        if (x > 3)
        {
            MessageBox.Show($"{x} > 3");
        }
        else
        {
            MessageBox.Show($"else {x} <= 3");
        }
    }

    private void BasicIfSyntaxDemo2(int x, int y)
    {
        // one line if statements = bad
        if (x > 3)
            MessageBox.Show($"{x} > 3");
        else
            MessageBox.Show($"else {x} <= 3");
    }

    private void BasicIfSyntaxDemo3(int x, int y)
    {
        // else if
        if (x > 3)
        {
            MessageBox.Show($"{x} > 3");
        }
        else if (x > 1)
        {
            MessageBox.Show($"{x} > 1 but <= 3");
        }
        else
        {
            MessageBox.Show($"{x} <= 1");
        }
    }

    private void BasicIfSyntaxDemo4(int x, int y)
    {
        // comparison operators
        if (x == 1)
        {
            MessageBox.Show($"{x} == 1");
        }

        if (x != 1)
        {
            MessageBox.Show($"{x} != 1");
        }
    }

    private void BasicIfSyntaxDemo5(int x, int y)
    {
        // and
        if ((x < 2) && (y < 2))
        {
            MessageBox.Show($"{x} < 2 AND {y} < 2");
        }

        // or
        if ((x < 2) || (y < 2))
        {
            MessageBox.Show($"{x} < 2 OR {y} < 2");
        }
    }

    private void ShortCircuitDemo()
    {
        string? str = null;

        // this crashes
        if (str.Length > 0)
        {
            MessageBox.Show("str not empty");
        }

        // but this does not
        if ((str != null) && (str.Length > 0))
        {
            MessageBox.Show("str is not null or empty");
        }
    }

    private void StringCompareDemo1()
    {
        string str1 = "abc";
        string str2 = "xyz";
        string str3 = "ABC";

        // String.Compare
        int retval = String.Compare(str1, str2);
        MessageBox.Show($"{str1} compare {str2} : {retval}");

        // case matters
        retval = String.Compare(str1, str3);
        MessageBox.Show($"{str1} compare {str3} : {retval}");

        // ignore case
        retval = String.Compare(str1, str3, true);
        MessageBox.Show($"{str1} compare no case {str3} : {retval}");

        // call from the string object
        retval = str1.CompareTo(str2);
        MessageBox.Show($"{str1}.compare {str2} : {retval}");
    }

    private void StringCompareDemo2()
    {
        string str1 = "abc";
        string str2 = "xyz";
        string str3 = "ABC";

        // String.Equals
        bool isEqual = String.Equals(str1, str3);
        MessageBox.Show($"{str1} equals {str3} : {isEqual}");

        // ignore case
        isEqual = String.Equals(str1, str3,
            StringComparison.OrdinalIgnoreCase);
        MessageBox.Show($"{str1} equals no case {str3} : {isEqual}");
    }

    private void StringCompareDemo3()
    {
        string str1 = "abc";
        string str2 = "xyz";
        string str3 = "ABC";

        // another way to ignore case
        int retval = str1.ToUpper().CompareTo(str3.ToUpper());
        MessageBox.Show($"{str1} to upper compare to {str3} : {retval}");

        // or
        if (str1.ToUpper() == str3.ToUpper())
        {
            MessageBox.Show($"{str1} to upper == {str3} to upper");
        }
    }

    private void runButton_Click(object sender, EventArgs e)
    {
        switch (demoListBox.SelectedIndex)
        {
            case -1:
                MessageBox.Show("select a demo");
                break;
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
                int x, y;

                if (!int.TryParse(xTextBox.Text, out x))
                {
                    MessageBox.Show("enter a valid value for x");
                    return;
                }

                if (!int.TryParse(yTextBox.Text, out y))
                {
                    MessageBox.Show("enter a valid vlaue for y");
                    return;
                }

                if (demoListBox.SelectedIndex == 0)
                    BasicIfSyntaxDemo1(x, y);
                else if (demoListBox.SelectedIndex == 1)
                    BasicIfSyntaxDemo2(x, y);
                else if (demoListBox.SelectedIndex == 2)
                    BasicIfSyntaxDemo3(x, y);
                else if (demoListBox.SelectedIndex == 3)
                    BasicIfSyntaxDemo4(x, y);
                else if (demoListBox.SelectedIndex == 4)
                    BasicIfSyntaxDemo5(x, y);
                break;
            case 5:
                ShortCircuitDemo();
                break;
            case 6:
                StringCompareDemo1();
                break;
            case 7:
                StringCompareDemo2();
                break;
            case 8:
                StringCompareDemo3();
                break;
            case 9:
                DefaultParamValueDemo();
                break;
            case 10:
                RefParamDemo();
                break;
            case 11:
                OutParamDemo();
                break;
            case 12:
                ReturnDemo();
                break;
            default:
                MessageBox.Show("select a demo");
                break;
        }
    }

    private enum PizzaCrust { ThinCrust, HandTossed, Pan }

    private void crustButton_Click(object sender, EventArgs e)
    {
        // an enum is not nullable by default
        //PizzaCrust crust = null;
        //PizzaCrust? crust = null;

        PizzaCrust crust = PizzaCrust.ThinCrust;

        // interact with radio buttons through their Checked property
        if (thinCrustRadioButton.Checked)
        {
            crust = PizzaCrust.ThinCrust;
        }

        if (panRadioButton.Checked)
        {
            crust = PizzaCrust.Pan;
        }

        if (handTossedRadioButton.Checked)
        {
            crust = PizzaCrust.HandTossed;
        }

        // lets examine how enums are stored
        int crustNumber = (int)crust;
        MessageBox.Show(crustNumber.ToString());
        MessageBox.Show(crust.ToString());

        // we often use a switch statement to process values of an enum
        switch (crust)
        {
            case PizzaCrust.ThinCrust:
                MessageBox.Show("you selected thin crust");
                break;
            case PizzaCrust.HandTossed:
                MessageBox.Show("you selected hand tossed");
                break;
            case PizzaCrust.Pan:
                MessageBox.Show("you selected pan");
                break;
            default:
                MessageBox.Show("unknown crust type");
                break;
        }

        // this is a switch EXPRESSION instead of a switch statement
        string msg = crust switch
        {
            PizzaCrust.ThinCrust => "Thin Crust",
            PizzaCrust.Pan => "Pan",
            PizzaCrust.HandTossed => "Hand Tossed",
            _ => "Unknown Crust"
        };
        MessageBox.Show(msg);
    }

    private void crustLoopButton_Click(object sender, EventArgs e)
    {
        // loop through each control in the group box
        foreach (Control c in crustGroupBox.Controls)
        {
            // make sure its a radio button
            if (c.GetType() == typeof(RadioButton))
            {
                // typecast generic control as radio button
                // so we can access radio button specific properties
                RadioButton rb = (RadioButton)c;
                if (rb.Checked)
                {
                    MessageBox.Show(rb.Name);
                    // there should only be one checked at a time
                    // so you could return here
                    // but we aren't going to so we can show it loop through all of them
                }
            }
        }
    }

    private void toppingDemoButton_Click(object sender, EventArgs e)
    {
        if (toppingPepperoniCheckBox.Checked)
        {
            MessageBox.Show("you want pepperoni");
        }

        if (toppingsSausageCheckBox.Checked)
        {
            MessageBox.Show("you want sausage");
        }

        if (toppingsMushroomsCheckBox.Checked)
        {
            MessageBox.Show("you want mushrooms");
        }

        if (toppingsPeppersCheckBox.Checked)
        {
            MessageBox.Show("you want peppers");
        }
    }

    private void checkAllButton_Click(object sender, EventArgs e)
    {
        toppingPepperoniCheckBox.Checked = true;
        toppingsMushroomsCheckBox.Checked = true;
        toppingsSausageCheckBox.Checked = true;
        toppingsPeppersCheckBox.Checked = true;
    }

    private void clearListButton_Click(object sender, EventArgs e)
    {
        demoListBox.Items.Clear();
    }

    private void UpdatePizzaTime()
    {
        // T is long time
        string time = DateTime.Now.ToString("T");
        lastChangedLabel.Text = $"Pizza changed at {time}";
    }

    private void thinCrustRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        UpdatePizzaTime();
    }

    private void handTossedRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        UpdatePizzaTime();
    }

    private void panRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        UpdatePizzaTime();
    }

    private void toppingPepperoniCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        UpdatePizzaTime();
    }

    private void toppingsSausageCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        UpdatePizzaTime();
    }

    private void toppingsMushroomsCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        UpdatePizzaTime();
    }

    private void toppingsPeppersCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        UpdatePizzaTime();
    }
}



