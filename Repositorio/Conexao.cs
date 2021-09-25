﻿using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Repositorio
{
    public class Conexao
    {
        MySqlConnection cn = new MySqlConnection("Server=localhost;DataBase=dbGameStore;user=brunogames;pwd=123321");
        public static string msg;
        public MySqlConnection ConectarBD()
        {
            try
            {
                cn.Open();
            }
            catch (Exception erro)
            {
                msg = "Ocorreu um erro ao conectar" + erro.Message;
            }
            return cn;
        }

        public MySqlConnection DesconectarBD()
        {
            try
            {
                cn.Close();
            }
            catch (Exception erro)
            {
                msg = "Ocorreu um erro ao desconectar" + erro.Message;
            }
            return cn;
        }

    }
}