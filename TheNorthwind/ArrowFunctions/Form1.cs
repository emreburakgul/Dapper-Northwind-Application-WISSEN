using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrowFunctions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ClickMethod(object p1, EventArgs p2)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var button = new Button();
            button.Click += ClickMethod;
            button.Click += (p1, p2) =>
            {

            };




            // Action: Dönüş tipi olmayan Arrow Function
            Action doSomething = () =>
            {

            };

            // metodu çağırmak
            doSomething.Invoke();
            doSomething();

            // string tipinde parametre alan, dönüş tipi olmayan (void) metot tanımlama
            Action<string> doSomething2 = (name) =>
            {

            };

            doSomething2("Tsubasa");
            doSomething2.Invoke("Tsubasa");


            // Func: Dönüş tipi olan Arrow Function
            Func<int> returnNumber = () =>
            {
                return 0;
            };

            var number = returnNumber.Invoke();


            //Func<string, int> lengthOfName = (string name) =>
            //{
            //    return name.Length;
            //};

            Func<string, int> lengthOfName;

            lengthOfName = LengthOfName;
            lengthOfName = (name) => name.Length;
            lengthOfName = (name) =>
            {
                return name.Length;
            };

            int length;
            length = lengthOfName("Tsubasa");
            length = lengthOfName.Invoke("Tsubasa");
        }

        int LengthOfName(string name)
        {
            return name.Length;
        }

        void DoSomething()
        {

        }

        int ReturnNumber()
        {
            return 0;
        }
    }
}
