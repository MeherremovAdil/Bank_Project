namespace Bank;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        button1.Click += button1_Click;
        button2.Click += button2_Click;
    }

    decimal price = 0; decimal total = 0;

    private void button1_Click(object sender, EventArgs e){
        price = Convert.ToDecimal(textBox1.Text);
        total = total + price;
        label2.Text = $"Mebleg : {total} manat";
    }

    private void button2_Click(object sender, EventArgs e){
        price = Convert.ToDecimal(textBox1.Text);
        if(price > total){
            label3.Visible = true;
            label2.Text = $"mebleg : {total} manat";
        }
        else{
            label3.Visible = false;
            total = total - price;
            label2.Text = $"mebleg : {total} manat";
        }
    }

    
}

