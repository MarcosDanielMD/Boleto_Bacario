namespace Boleto_Bancário
{
    public partial class FormBoleto : Form
    {
        public FormBoleto()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double valor, multa, juros, desconto, Vmulta, Vdesconto, Vjuros, acressimos, total;
            DateTime vencimento, pagamento;
            int dias;

            valor = double.Parse(txtbValor.Text);
            vencimento = DateTime.Parse(txtbVenc.Text);
            pagamento = DateTime.Parse(txtbPag.Text);
            multa = double.Parse(txtbMulta.Text);
            juros = double.Parse(txtbJuros.Text);
            desconto = double.Parse(txtbDesc.Text);

            //processamento

            //dias atrasados
            if (pagamento > vencimento)
            {
                dias = (pagamento - vencimento).Days;
            }
            else
            {
                dias = 0;
            }

            txtbDA.Text = dias.ToString();

            //multa

            if (pagamento > vencimento)
            {
                Vmulta = (multa / 100) * valor;
            }
            else
            {
                Vmulta = 0;
            }
            txtbVM.Text = multa.ToString("C");

            //juros

            if (pagamento > vencimento)
            {
                Vjuros = (juros / 100) * dias * valor;
            }
            else
            {
                Vjuros = 0; 
            }

            txtbVJ.Text = Vjuros.ToString("C");    

            //desconto

            if (vencimento > pagamento)
            {
                Vdesconto = (desconto / 100) * valor;
            }
            else
            {
                Vdesconto = 0;
            }
            txtbVD.Text= Vdesconto.ToString("C");

            //acressimos

            acressimos = Vmulta + Vjuros;

            total = valor + acressimos - Vdesconto;

            txtbTotal.Text = total.ToString("C");
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtbValor.Clear();
            txtbVenc.Clear();
            txtbVenc.Clear();
            txtbPag.Clear();
            txtbMulta.Clear();
            txtbJuros.Clear();
            txtbDesc.Clear();
        }

        private void brnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}   