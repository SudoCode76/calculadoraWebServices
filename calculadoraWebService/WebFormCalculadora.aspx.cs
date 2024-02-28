using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace calculadoraWebService
{
    public partial class WebFormCalculadora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void clickSumar(object sender, EventArgs e)
        {
            ServiceSuma.WebService1SoapClient sumaService = new ServiceSuma.WebService1SoapClient();
            int num1 = int.Parse(TextBox1.Text);
            int num2 = int.Parse(TextBox2.Text);

            int result = sumaService.suma(num1, num2);
            TextBox3.Text = result.ToString();

        }

        protected void clickRestar(object sender, EventArgs e)
        {
            ServiceResta.WebService1SoapClient restaService = new ServiceResta.WebService1SoapClient();
            int num1 = int.Parse(TextBox1.Text);
            int num2 = int.Parse(TextBox2.Text);

            int result = restaService.resta(num1, num2);
            TextBox3.Text = result.ToString();

        }

        protected void clickMultiplicar(object sender, EventArgs e)
        {
            ServiceMultiplicacion.WebService1SoapClient multiplicacionService = new ServiceMultiplicacion.WebService1SoapClient();
            int num1 = int.Parse(TextBox1.Text);
            int num2 = int.Parse(TextBox2.Text);

            int result = multiplicacionService.multiplicacion(num1, num2);
            TextBox3.Text = result.ToString();

        }

        protected void clickDividir(object sender, EventArgs e)
        {
            ServiceDivision.WebService1SoapClient divisionService = new ServiceDivision.WebService1SoapClient();
            int num1 = int.Parse(TextBox1.Text);
            int num2 = int.Parse(TextBox2.Text);

            int result = divisionService.division(num1, num2);
            TextBox3.Text = result.ToString();

        }


        //suma
        /*protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceSuma.WebService1SoapClient sumaService = new ServiceSuma.WebService1SoapClient();
            int num1 = int.Parse(TextBox1.Text);
            int num2 = int.Parse(TextBox2.Text);

            int result = sumaService.suma(num1, num2);
            TextBox3.Text = result.ToString();

        }*/




    }
}