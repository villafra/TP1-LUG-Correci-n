using System.Data;
using System.Data.SqlClient;

namespace Conexión.DataBase
{
    public class ClsDataBase
    {
        #region Variables Privadas

        private SqlConnection _objsqlConnection;
        private SqlDataAdapter _objsqlDataAdapter;
        private SqlCommand _objsqlCommand;
        private DataSet _dsResultados;
        private DataTable _dtParámetros;
        private string _nombreTabla, _nombreSP, _mensajeErrorDB, _valorScalar, _connectionString;
        private bool _scalar;



        //_connectionString = @"Data Source=(localdb)\server;Initial Catalog=TPN1-LUG;Integrated Security=True";






        #endregion

        #region Variables Públicas
        public SqlConnection ObjsqlConnection { get => _objsqlConnection; set => _objsqlConnection = value; }
        public SqlDataAdapter ObjsqlDataAdapter { get => _objsqlDataAdapter; set => _objsqlDataAdapter = value; }
        public SqlCommand ObjsqlCommand { get => _objsqlCommand; set => _objsqlCommand = value; }
        public DataSet DSResultados { get => _dsResultados; set => _dsResultados = value; }
        public DataTable DTParámetros { get => _dtParámetros; set => _dtParámetros = value; }
        public string NombreTabla { get => _nombreTabla; set => _nombreTabla = value; }
        public string NombreSP { get => _nombreSP; set => _nombreSP = value; }
        public string MensajeErrorDB { get => _mensajeErrorDB; set => _mensajeErrorDB = value; }
        public string ValorScalar { get => _valorScalar; set => _valorScalar = value; }
        public string ConnectionString { get => _connectionString; set => _connectionString = value; }
        public bool Scalar { get => _scalar; set => _scalar = value; }




        #endregion

        #region Constructores
        public ClsDataBase()
        {
            DTParámetros = new DataTable("SpParámetros");
            DTParámetros.Columns.Add("Nombre");
            DTParámetros.Columns.Add("TipoDato");
            DTParámetros.Columns.Add("Valor");

            ConnectionString = string.Empty;
        }

        #endregion

        #region Métodos Privados

        private void CrearConexioinBaseDatos(ref ClsDataBase objDataBase)
        {

        }
        private void ValidarConexionBaseDatos(ref ClsDataBase objDataBase)
        {

        }
        private void AgregarParametros(ref ClsDataBase objDataBase)
        {

        }
        private void PrepararConexionBaseDatos(ref ClsDataBase objDataBase)
        {

        }
        private void EjecutarDataAdapter(ref ClsDataBase objDataBase)
        {

        }
        private void EjecutarCommand(ref ClsDataBase objDataBase)
        {

        }

        #endregion

        #region Variables Públicos

        #endregion
    }
}
