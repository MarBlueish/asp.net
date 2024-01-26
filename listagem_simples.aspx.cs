using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace exer4
{
    public partial class listagem_simples : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection con;
            // veja a imagem abaixo para saber onde vai buscar o caminho da conexão
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\exer4\App_Data\dbsql.mdf;Integrated Security=True";
            con = new SqlConnection(connetionString);
            con.Open();
            //Response.Write("Ligado com sucesso!");
            // a linha acima utilizo apenas para ver se a conexão é feita com sucesso
            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = " ";
            sql = "Select Id, nome, n_paginas, tamanho from livro";
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();
            while (dataReader.Read()) 
            {
                Output = Output + dataReader.GetValue(0) + "-" + dataReader.GetValue(1) + "-" + "-" + dataReader.GetValue(2) + dataReader.GetValue(3) + "</br";
            }
            Response.Write(Output);
            dataReader.Close();
            con.Close();
        }
    
    }
}