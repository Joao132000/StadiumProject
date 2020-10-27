using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MetroFrameworkProject
{
    class StadiumData
    {
        private int idStadium;
        private string stadiumName;
        private string stadiumState;
        public int IdStadium { get => idStadium; set => idStadium = value; }
        public string StadiumName { get => stadiumName; set => stadiumName = value; }
        public string StadiumState { get => stadiumState; set => stadiumState = value; }

        DataConect obj = new DataConect();

        public void IncludeData()
        {
            string sql = "";
            sql += "Insert into Estadio (nomeEstadio, Estado) values ('" + StadiumName + "','" + StadiumState + "')";
            obj.Execute(sql);
        }

        public void UpdateData()
        {
            string sql = "";
            sql += "Update Estadio set nomeEstadio = '" + StadiumName + "', Estado='" + StadiumState + "' where idEstadio= " + IdStadium.ToString();
            obj.Execute(sql);
        }

        public void DeleteData()
        {
            string sql = "";
            sql += "delete from Estadio where idEstadio=" + IdStadium.ToString();
            obj.Execute(sql);
        }

        public DataSet ListData()
        {
            string sql = "";
            sql = "Select * from Estadio";
            return obj.List(sql);
        }

        public void ConsultData()
        {
            string sql = "";
            sql = "Select * from Estadio where idEstadio = " + IdStadium.ToString();
            obj.Consult(sql);
            string[] aux = obj.Fields.Split(';');
            StadiumName = aux[1];
            StadiumState = aux[2];
            
        }


    }

}
