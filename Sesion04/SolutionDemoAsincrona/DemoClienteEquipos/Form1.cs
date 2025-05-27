namespace DemoClienteEquipos
{
    public partial class Form1 : Form
    {
        //Instanciamos el servicio
        ProxyEquipos.Service1Client objServicio = new ProxyEquipos.Service1Client();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSincrono_Click(object sender, EventArgs e)
        {
            try
            {
                List<String> lstJugadores = objServicio.ObtenerJugadores();
                List<String> lstCiudades = objServicio.ObtenerCiudades();

                lista1.DataSource = lstCiudades;
                lista2.DataSource = lstJugadores;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private async void btnAsincrono_Click(object sender, EventArgs e)
        {
            try
            {
                //Delegamos a una tarea la ejecutamos asincrona de la operacion ObtenerJugadores
                Task<List<String>> lstJugadores = objServicio.ObtenerJugadoresAsync();
                //Mientras se ejecuta la operacion obtener jugadores, sigue ejecutando el codigo
                List<String> lstCiudades = objServicio.ObtenerCiudades();
                lista1.DataSource = lstCiudades;

                //Para garantizar que al final de la operacion asincrona 2
                List<String> taskEnded = await lstJugadores;
                lista2.DataSource = taskEnded;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
    }
}
