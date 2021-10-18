using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G4_Ejercicio4
{
    public partial class FrmPrograma : Form
    {

        private int edit_indice = -1;

        //Creamos las listas de las 3 clases heredadas
        List<Moto> Motos = new List<Moto>();
        List<Carro> Carros = new List<Carro>();
        List<Bus> Buses = new List<Bus>();

        //Creamos el data table en la que iran las listas para presentarlas en el DGV
        DataTable tablaMoto = new DataTable();
        DataTable tablacarro = new DataTable();
        DataTable tablabus = new DataTable();
        
        //Este metodo actualizará los registros de la tabla moto
        private void LlenarMotos(List<Moto> Motos)
        {
            tablaMoto.Rows.Clear();
            foreach (Moto m in Motos)
            {
                tablaMoto.Rows.Add(m.Llantas, m.Pasajeros, m.Masa, m.Rines, m.Tipomotor, m.Transmision, m.Combustible);
            }
            Dgvregistromoto.DataSource = null;
            Dgvregistromoto.DataSource = tablaMoto;
        }

        //Este metodo actualizará los registros de la tabla carro
        private void LlenarCarros(List<Carro> Carros)
        {
            tablacarro.Rows.Clear();
            foreach (Carro c in Carros)
            {
                tablacarro.Rows.Add(c.Llantas, c.Pasajeros, c.Masa, c.Rines, c.Tipomotor, c.Transmision, c.Combustible);
            }
            DgvregistroCarro.DataSource = null;
            DgvregistroCarro.DataSource = tablacarro;
        }

        //Este metodo actualizará los registros de la tabla bus
        private void LlenarBus(List<Bus> Buses)
        {
            tablaMoto.Rows.Clear();
            foreach (Bus b in Buses)
            {
                tablabus.Rows.Add(b.Llantas, b.Pasajeros, b.Masa, b.Rines, b.Tipomotor, b.Transmision, b.Combustible);
            }
            DgvregistroBus.DataSource = null;
            DgvregistroBus.DataSource = tablabus;
        }

        //Creamos un metodo para limpiar los campos despues de ingresar los vehiculos
        private void limpìar()
        {
            txtmasavehiculo.Clear();
            txtnllantas.Clear();
            txtnpasajeros.Clear();
            txtrin.Clear();
            txtnllantas.Focus();
        }

        private void cmbcombustible_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmPrograma_Load(object sender, EventArgs e)
        {
            
        }

        public FrmPrograma()
        {
            InitializeComponent();

            //Agregamos las columnas a la tabla Moto
            tablaMoto.Columns.Add(new DataColumn("Numero de llantas", typeof(int)));
            tablaMoto.Columns.Add(new DataColumn("Cantidad de pasajeros", typeof(int)));
            tablaMoto.Columns.Add(new DataColumn("Masa del vehiculo", typeof(double)));
            tablaMoto.Columns.Add(new DataColumn("Tamaño de rines", typeof(int)));
            tablaMoto.Columns.Add(new DataColumn("Tipo de motor", typeof(string)));
            tablaMoto.Columns.Add(new DataColumn("Transmision", typeof(string)));
            tablaMoto.Columns.Add(new DataColumn("Combustible", typeof(string)));

            //Agregamos las columnas a la tabla carro
            tablacarro.Columns.Add(new DataColumn("Numero de llantas", typeof(int)));
            tablacarro.Columns.Add(new DataColumn("Cantidad de pasajeros", typeof(int)));
            tablacarro.Columns.Add(new DataColumn("Masa del vehiculo", typeof(double)));
            tablacarro.Columns.Add(new DataColumn("Tamaño de rines", typeof(int)));
            tablacarro.Columns.Add(new DataColumn("Tipo de motor", typeof(string)));
            tablacarro.Columns.Add(new DataColumn("Transmision", typeof(string)));
            tablacarro.Columns.Add(new DataColumn("Combustible", typeof(string)));

            //Agregamos las columnas a la tabla bus
            tablabus.Columns.Add(new DataColumn("Numero de llantas", typeof(int)));
            tablabus.Columns.Add(new DataColumn("Cantidad de pasajeros", typeof(int)));
            tablabus.Columns.Add(new DataColumn("Masa del vehiculo", typeof(double)));
            tablabus.Columns.Add(new DataColumn("Tamaño de rines", typeof(int)));
            tablabus.Columns.Add(new DataColumn("Tipo de motor", typeof(string)));
            tablabus.Columns.Add(new DataColumn("Transmision", typeof(string)));
            tablabus.Columns.Add(new DataColumn("Combustible", typeof(string)));


        }

        private void btncrearvehiculo_Click(object sender, EventArgs e)
        {
            //Creamos los objetos de cada clase
            Moto mot = new Moto();
            Carro car = new Carro();
            Bus bus = new Bus();

            //Creamos las ramas para cada vehiculo 

            if (cmbvehiculo.SelectedItem.ToString() == "Moto" ) //Definimos los procedimientos cuando el vehiculo sea una MOTO
            {

                //Asignamos las variables a los textbox
                mot.Llantas = int.Parse(txtnllantas.Text);
                mot.Pasajeros = int.Parse(txtnpasajeros.Text);
                mot.Masa = double.Parse(txtmasavehiculo.Text);
                mot.Rines = int.Parse(txtrin.Text);

                //Creamos las restricciones para la clase
                if (cmbmotor.SelectedItem.ToString() == "Combustion")
                {
                    mot.Tipomotor = "Combustion";

                    //Definimos el tipo de transmision
                    if (cmbtransmision.SelectedItem.ToString() == "Automatico")
                    {
                        mot.Transmision = "Automatico";
                    }
                    if (cmbtransmision.SelectedItem.ToString() == "Manual")
                    {
                        mot.Transmision = "Manual";
                    }

                    //Definimos el tipo de combustible

                    if (cmbcombustible.SelectedItem.ToString() == "Gasolina")
                    {
                        mot.Combustible = "Gasolina";
                    }
                    if (cmbcombustible.SelectedItem.ToString() == "Diesel")
                    {
                        mot.Combustible = "Diesel";
                    }
                    if (cmbcombustible.SelectedItem.ToString() == "Electricidad")
                    {
                        MessageBox.Show("No exite un vehiculo con motor de cobustion que use electricidad como combustible");
                        limpìar();
                    }

                }
                if (cmbmotor.SelectedItem.ToString() == "Electrico")
                {
                    mot.Tipomotor = "Electrico";

                    if (cmbtransmision.SelectedItem.ToString() == "Automatico")
                    {
                        mot.Transmision = "Automatico";
                    }
                    if (cmbtransmision.SelectedItem.ToString() == "Manual")
                    {
                        mot.Transmision = "Manual";
                    }

                    mot.Combustible = "Electricidad";

                }

                if (edit_indice > -1)
                {
                    Motos[edit_indice] = mot;
                    edit_indice = -1;
                }
                else
                {
                    Motos.Add(mot); //Al arreglo Motos, le añado el objeto "mot"
                }

            }


            if (cmbvehiculo.SelectedItem.ToString() == "Carro") //Definimos los procedimientos cuando el vehiculo sea un CARRO
            {

                //Asignamos las variables a los textbox
                car.Llantas = int.Parse(txtnllantas.Text);
                car.Pasajeros = int.Parse(txtnpasajeros.Text);
                car.Masa = double.Parse(txtmasavehiculo.Text);
                car.Rines = int.Parse(txtrin.Text);

                //Creamos las restricciones para la clase
                if (cmbmotor.SelectedItem.ToString() == "Combustion")
                {
                    car.Tipomotor = "Combustion";

                    //Definimos el tipo de transmision
                    if (cmbtransmision.SelectedItem.ToString() == "Automatico")
                    {
                        car.Transmision = "Automatico";
                    }
                    if (cmbtransmision.SelectedItem.ToString() == "Manual")
                    {
                        car.Transmision = "Manual";
                    }

                    //Definimos el tipo de combustible

                    if (cmbcombustible.SelectedItem.ToString() == "Gasolina")
                    {
                        car.Combustible = "Gasolina";
                    }
                    if (cmbcombustible.SelectedItem.ToString() == "Diesel")
                    {
                        car.Combustible = "Diesel";
                    }
                    if (cmbcombustible.SelectedItem.ToString() == "Electricidad")
                    {
                        MessageBox.Show("No exite un vehiculo con motor de cobustion que use electricidad como combustible");
                        limpìar();
                    }


                }
                if (cmbmotor.SelectedItem.ToString() == "Electrico")
                {
                    car.Tipomotor = "Electrico";

                    if (cmbtransmision.SelectedItem.ToString() == "Automatico")
                    {
                        car.Transmision = "Automatico";
                    }
                    if (cmbtransmision.SelectedItem.ToString() == "Manual")
                    {
                        car.Transmision = "Manual";
                    }

                    car.Combustible = "Electricidad";

                }

                if (edit_indice > -1)
                {
                    Carros[edit_indice] = car;
                    edit_indice = -1;
                }
                else
                {
                    Carros.Add(car); //Al arreglo Carros, le añado el objeto "car"
                }

            }

            if (cmbvehiculo.SelectedItem.ToString() == "Bus") //Definimos los procedimientos cuando el vehiculo sea un BUS
            {

                //Asignamos las variables a los textbox
                bus.Llantas = int.Parse(txtnllantas.Text);
                bus.Pasajeros = int.Parse(txtnpasajeros.Text);
                bus.Masa = double.Parse(txtmasavehiculo.Text);
                bus.Rines = int.Parse(txtrin.Text);

                //Creamos las restricciones para la clase
                if (cmbmotor.SelectedItem.ToString() == "Combustion")
                {
                    bus.Tipomotor = "Combustion";

                    //Definimos el tipo de transmision
                    if (cmbtransmision.SelectedItem.ToString() == "Automatico")
                    {
                        bus.Transmision = "Automatico";
                    }
                    if (cmbtransmision.SelectedItem.ToString() == "Manual")
                    {
                        bus.Transmision = "Manual";
                    }

                    //Definimos el tipo de combustible

                    if (cmbcombustible.SelectedItem.ToString() == "Gasolina")
                    {
                        bus.Combustible = "Gasolina";
                    }
                    if (cmbcombustible.SelectedItem.ToString() == "Diesel")
                    {
                        bus.Combustible = "Diesel";
                    }
                    if (cmbcombustible.SelectedItem.ToString() == "Electricidad")
                    {
                        MessageBox.Show("No exite un vehiculo con motor de cobustion que use electricidad como combustible");
                        limpìar();
                    }

                }
                if (cmbmotor.SelectedItem.ToString() == "Electrico")
                {
                    bus.Tipomotor = "Electrico";

                    if (cmbtransmision.SelectedItem.ToString() == "Automatico")
                    {
                        bus.Transmision = "Automatico";
                    }
                    if (cmbtransmision.SelectedItem.ToString() == "Manual")
                    {
                        bus.Transmision = "Manual";
                    }

                    bus.Combustible = "Electricidad";

                }

                if (edit_indice > -1)
                {
                    Buses[edit_indice] = bus;
                    edit_indice = -1;
                }
                else
                {
                    Buses.Add(bus); //Al arreglo Motos, le añado el objeto "mot"
                }

            }

            //Ya con los datos obtenidos, limpiamos los campos
            limpìar();

        }

        private void btnsalirprogram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmPrograma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnrefreshmoto_Click(object sender, EventArgs e)
        {
            //Creamos una lista que se usará en el DGV
            List<Moto> listamoto = new List<Moto>();

            /*foreach (Moto moto in Motos)
            {
                listamoto.Add(moto);
            }*/
            LlenarMotos(Motos);
        }

        private void btnrefreshcarro_Click(object sender, EventArgs e)
        {
            //Creamos una lista que se usará en el DGV
            List<Carro> listacarro = new List<Carro>();

            foreach (Carro ca in Carros)
            {
                listacarro.Add(ca);
            }
            LlenarCarros(listacarro);
        }

        private void btnrefreshbus_Click(object sender, EventArgs e)
        {
            //Creamos una lista que se usará en el DGV
            List<Bus> listabus = new List<Bus>();

            foreach (Bus bu in Buses)
            {
                listabus.Add(bu);
            }
            LlenarBus(listabus);
        }
    }
}
