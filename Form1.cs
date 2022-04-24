using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FechaSiguiente
{
    public partial class Form1 : Form
    {
        public class Mes
        {
            public string Nombre { get; set; }
            public int Dias { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private int mesDe28Dias = 28;
        private int mesDe30Dias = 30;
        private int mesDe31Dias = 31;
        private List<string> nombreMeses = new List<string>{
                "Enero",
                "Febrero",
                "Marzo",
                "Abril",
                "Mayo",
                "Junio",
                "Julio",
                "Agosto",
                "Septiembre",
                "Octubre",
                "Noviembre",
                "Diciembre"
            };
        private List<Mes> diasDelMes = new List<Mes>
        {
            new Mes {Nombre = "Enero", Dias = 31},
            new Mes {Nombre = "Febrero", Dias = 28},
            new Mes {Nombre = "Marzo", Dias = 31},
            new Mes {Nombre = "Abril", Dias = 30},
            new Mes {Nombre = "Mayo", Dias = 31},
            new Mes {Nombre = "Junio", Dias = 30},
            new Mes {Nombre = "Julio", Dias = 31},
            new Mes {Nombre = "Agosto", Dias = 31},
            new Mes {Nombre = "Septiembre", Dias = 30},
            new Mes {Nombre = "Octubre", Dias = 31},
            new Mes {Nombre = "Noviembre", Dias = 30},
            new Mes {Nombre = "Diciembre", Dias = 31}
        };

        public void ObtenerFechaSiguiente(object sender, EventArgs e)
        {
            /// Validamos si el contenido ingresado en string, no son numeros.
            if (!inputDia.Text.All(char.IsDigit) || 
                !inputMes.Text.All(char.IsDigit) || 
                !inputAño.Text.All(char.IsDigit)
                )
            {
                MessageError("El formato de fecha establecido no es el correcto. \nIntentelo nuevamente :D");
                return;
            }

            /// validamos la cantidad de caracteres que se puso en cada input.
            int numeroDelDia = inputDia.Text.Length <= 2 ? Int32.Parse(inputDia.Text) : 0;
            int numeroDelMes = inputMes.Text.Length <= 2 ? Int32.Parse(inputMes.Text) : 0;
            int numeroDelAño = inputAño.Text.Length <= 4 ? Int32.Parse(inputAño.Text) : 0;

            if (numeroDelDia <= 0 || numeroDelMes <= 0 || numeroDelAño <= 0)
            {
                MessageError("El formato de fecha establecido no es el correcto. \nIntentelo nuevamente :D");
                return;
            }

            if(numeroDelMes > 12)
            {
                MessageError("El año tiene solo 12 meses. \nIntentelo nuevamente :D");
                return;
            }

            string nuevaFecha = "";
            string nombreDelMes = ObtenerNombreDelMes(numeroDelMes);
            int cantidadDeDiasDelMes = ObtenerDiasDelMes(nombreDelMes);

            // En caso de haber ingresado un mes poseedor de 28 dias;
            if (cantidadDeDiasDelMes == mesDe28Dias)
            {
                if (verificarSiEsAñoBisiesto(numeroDelAño) && numeroDelDia > 29)
                {
                    MessageError(nombreDelMes + " tiene 29 dias (Año bisiesto). \nPor favor, ingrese una fecha menor a ese numero.");
                    return;
                }
                
                if (!verificarSiEsAñoBisiesto(numeroDelAño) && numeroDelDia > 28)
                {
                    MessageError(nombreDelMes + " tiene 28 dias. \nPor favor, ingrese una fecha menor a ese numero.");
                    return;
                }

                nuevaFecha = ValidarMes28Dias( numeroDelDia, numeroDelMes, numeroDelAño);
            }

            // En caso de haber ingresado un mes poseedor de 30 dias;
            if (cantidadDeDiasDelMes == mesDe30Dias)
            {
                if (numeroDelDia > 30)
                {
                    MessageError(nombreDelMes + " tiene 30 dias. \nPor favor, ingrese una fecha menor a ese numero.");
                    return;
                }

                nuevaFecha = ValidarMes30Dias(numeroDelDia, numeroDelMes, numeroDelAño);
            }

            // En caso de haber ingresado un mes poseedor de 31 dias;
            if (cantidadDeDiasDelMes == mesDe31Dias)
            {
                if (numeroDelDia > 31)
                {
                    MessageError(nombreDelMes +" tiene 31 dias. \nPor favor, ingrese una fecha menor a ese numero.");
                    return;
                }
                
                nuevaFecha = ValidarMes31Dias(nombreDelMes, numeroDelDia, numeroDelMes, numeroDelAño);
            }
             
            ResultadoFechaSig.Text = nuevaFecha;
            return;
        }

        #region Obtener Nombre y cantidad de dias del mes que ingresamos.

            public string ObtenerNombreDelMes(int numeroDelMes)
            {
                return nombreMeses[numeroDelMes - 1];
            }
            public int ObtenerDiasDelMes(string nombreDelMes)
            {
                int diaMes = 0;

                foreach (Mes mes in diasDelMes)
                {
                    if (mes.Nombre == nombreDelMes)
                    {
                        diaMes = mes.Dias;
                        break;
                    }
                }
                return diaMes;
            }
     
        #endregion

        #region Obtener Fechas dependiendo del caso

            public string ObtenerFechaSiguiente(int numeroDelDia, int numeroDelMes, int numeroDelAño)
            {
                string mes = ObtenerNombreDelMes(numeroDelMes);
                int dia = numeroDelDia + 1;

                return dia + " de " + mes + " del " + numeroDelAño;
            }
           
            public string ObtenerFechaMesSiguiente(int numeroDelMes, int numeroDelAño)
            {
                string mes = ObtenerNombreDelMes(numeroDelMes + 1);

                return "01 de " + mes + " del " + numeroDelAño;
            }
           
            public string ObtenerFechaAñoSiguiente(int numeroDelAño)
            {
                int año = numeroDelAño + 1;

                return "01 de Enero del " + año;
            }

        #endregion

        #region Validar nueva fecha dependiendo de los dias del mes.

            public string ValidarMes28Dias(int numeroDelDia, int numeroDelMes, int numeroDelAño)
            {
                string fechaReturn = "";              

                if (!verificarSiEsAñoBisiesto(numeroDelAño) && numeroDelDia < 28)
                {
                    fechaReturn = ObtenerFechaSiguiente(numeroDelDia, numeroDelMes, numeroDelAño);
                }

                if (verificarSiEsAñoBisiesto(numeroDelAño) && numeroDelDia < 29)
                {
                    fechaReturn = ObtenerFechaSiguiente(numeroDelDia, numeroDelMes, numeroDelAño);
                }

                if(!verificarSiEsAñoBisiesto(numeroDelAño) && numeroDelDia == 28 || 
                    verificarSiEsAñoBisiesto(numeroDelAño) && numeroDelDia == 29)
                {
                    fechaReturn = ObtenerFechaMesSiguiente(numeroDelMes, numeroDelAño);
                }

                return fechaReturn;
            }

            public string ValidarMes30Dias(int numeroDelDia, int numeroDelMes, int numeroDelAño)
            {
                string fechaReturn = "";

                if (numeroDelDia < 30)
                {
                    fechaReturn = ObtenerFechaSiguiente(numeroDelDia, numeroDelMes, numeroDelAño);
                }
                else
                {
                    fechaReturn = ObtenerFechaMesSiguiente(numeroDelMes, numeroDelAño);
                }

                return fechaReturn;
            }

            public string ValidarMes31Dias( string nombreDelMes, int numeroDelDia, int numeroDelMes, int numeroDelAño)
            {
                string fechaReturn = "";

                if (numeroDelDia < 31)
                {
                    fechaReturn = ObtenerFechaSiguiente(numeroDelDia, numeroDelMes, numeroDelAño);
                }

                if (numeroDelDia == 31 && nombreDelMes != "Diciembre")
                {
                    fechaReturn = ObtenerFechaMesSiguiente(numeroDelMes, numeroDelAño);
                }

                if (numeroDelDia == 31 && nombreDelMes == "Diciembre")
                {
                    fechaReturn = ObtenerFechaAñoSiguiente(numeroDelAño);
                }


                return fechaReturn;
            }

        #endregion

        public void MessageError(string message)
        {
            TextoIngreso.Text = message;
        }


        public bool verificarSiEsAñoBisiesto(int numeroDelAño)
        {
            Boolean bisiesto = false;
                
            if(numeroDelAño % 4 == 0 && numeroDelAño % 100 != 0 || numeroDelAño % 400 == 0)
            {
                bisiesto = true;
            }
            return bisiesto;
        }


        private void IntentarDeNuevo(object sender, EventArgs e)
        {
            inputDia.Text = "";
            inputMes.Text = "";
            inputAño.Text = "";
            TextoIngreso.Text = "La fecha siguiente a la que ingreso es:";
            ResultadoFechaSig.Text = "";
        }

    }
}
