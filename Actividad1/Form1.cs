using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vuelos;
namespace Actividad1
{
    public partial class Form1 : Form
    {   // Pasamos la informacon proporcionada de Vuelos a distintas listas que luego usaremos para desarrollar la aactividad
        List<Aerolinea> listaAerolinea = new List<Aerolinea>();
        List<Aeropuerto> listaAeropuerto = new List<Aeropuerto>();
        List<Vuelo> listaVuelos = new List<Vuelo>();
        List<Reserva> listaReserva = new List<Reserva>();
        public Form1()
        { 
            InitializeComponent();
            // asemos que las listas descarguen la informacion de los documentos recividos
            listaAerolinea = Aerolinea.importar("aerolineas.dat");
            listaAeropuerto = Aeropuerto.importar("aeropuertos.dat");
            listaVuelos = Vuelo.importar("vuelos.dat");
            // Estas funciones reellenan los listBox
            popularAerolinea();
            popularAeropuerto();
            textBox_numeroNiños.Text = "0";
        }
        public void popularAerolinea()
        {
            foreach (Aerolinea a in listaAerolinea)
                list_aerolinea.Items.Add(a.Nombre);
        }
        public void popularAeropuerto()
        {
            list_aeropuerto_origen.Items.Add("Todos");
            list_aeropuerto_destino.Items.Add("Todos");
            list_aerolinea.Items.Add("Todos");
            foreach (Aeropuerto a in listaAeropuerto)
            {
                
                list_aeropuerto_origen.Items.Add(a.Nombre); 
                list_aeropuerto_destino.Items.Add(a.Nombre);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Hacemos que el textBox de los billetes para los niños este oculto hasta que se pulse su respectivo checkBox
            textBox_numeroNiños.Visible = false;
        }


        // La funcion de a continuacion se encarga de hacer el TextBox_numeroNiños se haga visible o no
        public void niñosSi()
        {   

            Boolean a = checkBox_niños.Checked;
            if (a == true) { 
            textBox_numeroNiños.Visible = true;
            } else { textBox_numeroNiños.Visible = false; }
        }

        //La funcion validacion son una serie de if que retornaran numeros que luego serviran para filtrar los errores en un switch
        int validacion(){

            // Conjunto de variables que necesitaran los if para funcionar
            Boolean c = checkBox_niños.Checked;
            errorProvider1.SetError(panel_datos, "");
            errorProvider1.SetError(panel_fecha, "");
            errorProvider1.SetError(textBox_billetes, "");
            errorProvider1.SetError(textBox_codigo, "");
            DateTime a = dateTimePicker_fechaIda.Value;
            DateTime b = dateTimePicker_fechaVuelta.Value;

            // Cada if es una condicion que tendra el usuario para poder activar la reserv la primera por ejemplo pide que los listBox de destino,origen y aerolinea no este vacio.
            if ((list_aerolinea.SelectedIndex <= -1) || (list_aeropuerto_destino.SelectedIndex <= -1) || (list_aeropuerto_origen.SelectedIndex <= -1))
            {
                return 1;

                
            }
            else { if (a >= b) { return 2; }
                if (!(textBox_billetes.Text.All(Char.IsDigit)) || (textBox_billetes.Text == "")|| textBox_billetes.Text == "0")
                {
                    return 3;
                }if (c == true)
                {
                    if (!(textBox_numeroNiños.Text.All(Char.IsDigit)) || !(checkBox_niños.Text == ""))
                    {
                        return 4;
                    }
                }
                if (textBox_codigo.Text=="") { return 5; }
                return 0;
            }
        }


        private void bt_reserva_Click(object sender, EventArgs e)
        {
            // Aqui vemos el switch con la funcion validacion si todas las validaciones son correctar retornara un cero que hara que el boton reserva se active
            switch (validacion()) { case 0:

                    // Conjunto de errorProvider que necesito para que no se activen cuando no deban estar activados
                    errorProvider1.SetError(panel_datos, "");
                    errorProvider1.SetError(panel_fecha, "");
                    errorProvider1.SetError(textBox_billetes, "");
                    errorProvider1.SetError(textBox_billetes, "");
                    //Conjunto de variables que necesito para rellenar la reserva
                    String numero_billetes = textBox_billetes.Text;
                    int numero_billetes_2 = int.Parse(numero_billetes);
                    String numero_billetes_niño = textBox_numeroNiños.Text;
                    int numero_billetes_niño_2 = int.Parse(numero_billetes_niño);
                    Boolean equipaje_extra = CheckBox_EquipajeExtra.Checked;
                    String codigo = textBox_codigo.Text;
                    // Este forech recorre todos los codigos de los vuelos hasta que encuentra uno que es igual al introducido y entonces genera la reserva
                    // el int hace que cuincida con el seleccionado ya que suma uno por cada repeticion del bucle hasta que entra en el if
                    int i = -1;
                    foreach (Vuelo an in listaVuelos) {
                        i++;

                        if (codigo==an.Numero)
                        { 
                            Reserva r = new Reserva(listaVuelos[i], numero_billetes_2, numero_billetes_niño_2, equipaje_extra);
                            r.confirmar();

                        } else {}
                    }
                        
                    // Aqui estan las otras posivilidades del sqitch que tambien se activan con la funcion validacion 
                        break;
                case 1:
                    errorProvider1.SetError(panel_datos, "Rellene toda la informacion del panel");
                    break;
                case 2:
                    errorProvider1.SetError(panel_fecha, "La fecha de ida es inferior a la de vuelta");
                    break;
                case 3: errorProvider1.SetError(textBox_billetes, "Seleccione una cantidad de billetes para adultos");
                    break;
                case 4: errorProvider1.SetError(checkBox_niños, "Introdusca un valor valido");
                    break;
                case 5:
                    errorProvider1.SetError(textBox_codigo, "Introdusca un valor valido");
                    break;

            }
            
        }
        // Click del boton salir que cierra el programa
        private void button_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //CheckedChanged de checkBox de los niños que activa la funcion niñoSi que comentamos antes
        private void checkBox_niños_CheckedChanged(object sender, EventArgs e)
        {
            niñosSi();
        }

        //Este botton filtra las distintas condiciones del viaje
        private void button_filtro_Click(object sender, EventArgs e)
        {   //Primero pedimos que paso por algunas condiciones como que todos los listBox esten rellenos
            errorProvider1.SetError(panel_datos, "");
            if ((list_aerolinea.SelectedIndex <= -1) || (list_aeropuerto_destino.SelectedIndex <= -1) || (list_aeropuerto_origen.SelectedIndex <= -1))
            {
                errorProvider1.SetError(panel_datos, "Rellene toda la informacion para realizar el filtro");
            }
            else {

                // Creamos un ListViewItem con el que rellenaremos el listView
                ListViewItem elem;
                //Resetea el contenido del listView
                listView1.Items.Clear();


                //Esta lista de variable 0 cogen los valores insertados en los distintos controles
                DateTime filtro_fecha_ida_0 = dateTimePicker_fechaIda.Value;
                DateTime filtro_fecha_vuelta_0 = dateTimePicker_fechaVuelta.Value;
                String filtro_aerolinea_0 = list_aerolinea.SelectedItem.ToString();
                String filtro_origen_0 = list_aeropuerto_origen.SelectedItem.ToString();
                String filtro_destino_0 = list_aeropuerto_destino.SelectedItem.ToString();
                
                foreach (Vuelo an in listaVuelos)
                {


                    //Estas variable 1 recogen continuamente el valor dentro de vuelo que el for va seleccionando
                    //Este valor junto con el que se encuentra introducido en el controlador se introducen en una
                    // variable 3 que es un boolian que da false o true si estos dos datos cuinciden
                    DateTime filtro_fecha_ida_1 = an.Fecha.Date;
                    Boolean filtro_fecha_ida_2 = filtro_fecha_ida_1 >= filtro_fecha_ida_0;
                    String filtro_origen_1 = an.Origen.Nombre.ToString();
                    Boolean filtro_origen_2 = filtro_origen_0 == filtro_origen_1;
                    Boolean filtro_origen_3 = filtro_origen_0 =="Todos";
                    String filtro_aerolinea_1 = an.Aerolinea.Nombre.ToString();
                    Boolean filtro_aerolinea_2 = filtro_aerolinea_0 == filtro_aerolinea_1;
                    Boolean filtro_aerolinea_3 = filtro_aerolinea_0 == "Todos";
                    String filtro_destino_1 = an.Destino.Nombre.ToString();
                    Boolean filtro_destino_2 = filtro_destino_0 == filtro_destino_1;
                    Boolean filtro_destino_3= filtro_destino_0 == "Todos";
                    Boolean filtro_nacional = an.Origen.Nacional;


                    //Estas variables tipo boolean se introducen en un conjunto de if anidados que permiten que el listView 
                    //Muestre las opciones seleccionadas
                    if (filtro_fecha_ida_2)
                    {
                        if (filtro_aerolinea_2)
                        {

                            if (filtro_destino_2 && filtro_origen_2)
                            {
                                elem = listView1.Items.Add(an.Aerolinea.Nombre);
                                elem.SubItems.Add(an.Numero);
                                elem.SubItems.Add(an.Fecha.ToString());
                                elem.SubItems.Add(an.Origen.Nombre);
                                elem.SubItems.Add(an.Destino.Nombre);
                                if (filtro_nacional)
                                {
                                    String nacional = "Nacional";
                                    elem.SubItems.Add(nacional);

                                }
                                else { elem.SubItems.Add("No nacional"); }
                            }
                            else
                            {

                                if (filtro_destino_2 && filtro_origen_3)
                                {
                                    elem = listView1.Items.Add(an.Aerolinea.Nombre);
                                    elem.SubItems.Add(an.Numero);
                                    elem.SubItems.Add(an.Fecha.ToString());
                                    elem.SubItems.Add(an.Origen.Nombre);
                                    elem.SubItems.Add(an.Destino.Nombre);
                                    if (filtro_nacional)
                                    {
                                        String nacional = "Nacional";
                                        elem.SubItems.Add(nacional);

                                    }
                                    else { elem.SubItems.Add("No nacional"); }
                                }

                                if (filtro_origen_2 && filtro_destino_3)
                                {
                                    elem = listView1.Items.Add(an.Aerolinea.Nombre);
                                    elem.SubItems.Add(an.Numero);
                                    elem.SubItems.Add(an.Fecha.ToString());
                                    elem.SubItems.Add(an.Origen.Nombre);
                                    elem.SubItems.Add(an.Destino.Nombre);
                                    if (filtro_nacional)
                                    {
                                        String nacional = "Nacional";
                                        elem.SubItems.Add(nacional);

                                    }
                                    else { elem.SubItems.Add("No nacional"); }
                                }
                                if (filtro_origen_3 && filtro_destino_3)
                                {
                                    elem = listView1.Items.Add(an.Aerolinea.Nombre);
                                    elem.SubItems.Add(an.Numero);
                                    elem.SubItems.Add(an.Fecha.ToString());
                                    elem.SubItems.Add(an.Origen.Nombre);
                                    elem.SubItems.Add(an.Destino.Nombre);
                                    if (filtro_nacional)
                                    {
                                        String nacional = "Nacional";
                                        elem.SubItems.Add(nacional);

                                    }
                                    else { elem.SubItems.Add("No nacional"); }
                                }
                            }
                        }
                        if (filtro_aerolinea_3)
                        {

                            if (filtro_destino_2 && filtro_origen_2)
                            {
                                elem = listView1.Items.Add(an.Aerolinea.Nombre);
                                elem.SubItems.Add(an.Numero);
                                elem.SubItems.Add(an.Fecha.ToString());
                                elem.SubItems.Add(an.Origen.Nombre);
                                elem.SubItems.Add(an.Destino.Nombre);
                                if (filtro_nacional)
                                {
                                    String nacional = "Nacional";
                                    elem.SubItems.Add(nacional);

                                }
                                else { elem.SubItems.Add("No nacional"); }
                            }
                            else
                            {

                                if (filtro_destino_2 && filtro_origen_3)
                                {
                                    elem = listView1.Items.Add(an.Aerolinea.Nombre);
                                    elem.SubItems.Add(an.Numero);
                                    elem.SubItems.Add(an.Fecha.ToString());
                                    elem.SubItems.Add(an.Origen.Nombre);
                                    elem.SubItems.Add(an.Destino.Nombre);
                                    if (filtro_nacional)
                                    {
                                        String nacional = "Nacional";
                                        elem.SubItems.Add(nacional);

                                    }
                                    else { elem.SubItems.Add("No nacional"); }
                                }

                                if (filtro_origen_2 && filtro_destino_3)
                                {
                                    elem = listView1.Items.Add(an.Aerolinea.Nombre);
                                    elem.SubItems.Add(an.Numero);
                                    elem.SubItems.Add(an.Fecha.ToString());
                                    elem.SubItems.Add(an.Origen.Nombre);
                                    elem.SubItems.Add(an.Destino.Nombre);
                                    if (filtro_nacional)
                                    {
                                        String nacional = "Nacional";
                                        elem.SubItems.Add(nacional);

                                    }
                                    else { elem.SubItems.Add("No nacional"); }
                                }
                                if (filtro_origen_3 && filtro_destino_3)
                                {
                                    elem = listView1.Items.Add(an.Aerolinea.Nombre);
                                    elem.SubItems.Add(an.Numero);
                                    elem.SubItems.Add(an.Fecha.ToString());
                                    elem.SubItems.Add(an.Origen.Nombre);
                                    elem.SubItems.Add(an.Destino.Nombre);
                                    if (filtro_nacional)
                                    {
                                        String nacional = "Nacional";
                                        elem.SubItems.Add(nacional);

                                    }
                                    else { elem.SubItems.Add("No nacional"); }
                                }
                            }
                        }
                    }

                        
                    
                        
                    
                    
                        


                }
                
            }
        
    }
        //Este boton muestraa informacion extra sobre la aplicacion
        private void button_Informacion_Click(object sender, EventArgs e)
        {
            String respuesta_final = " Creador: Juan Luis Gomez Garcia. \n Asignatura: Entornos de desarrollo.\n Ayuda:La aplicacion permite un filtrado total por origen,destino y aerolinea.\n Necesita la introduccion del codigo de vuelo para conceder la reserva.";

            MessageBox.Show(respuesta_final);
        }

        private void list_aerolinea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
