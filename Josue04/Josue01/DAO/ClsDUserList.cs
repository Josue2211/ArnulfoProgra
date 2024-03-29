﻿using Josue01.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Josue01.DAO
{
    class ClsDUserList
    {

        public List<UserList> cargarDatosUserList()
        {
            List<UserList> Lista;

            using (programacionEntities db = new programacionEntities())
            {
                Lista = db.UserList.ToList();
            }

            return Lista;
        }
        //public void SaveDatosUser(String Nombre, String Apellido, int Edad, String Pass)
        //{
        //    try
        //    {
        //        using (programacionEntities db = new programacionEntities())
        //        {

        //            UserList userList = new UserList();

        //            userList.NombreUsuario = Nombre;
        //            userList.Apellido = Apellido;
        //            userList.Edad = Edad;
        //            userList.Pass = Pass;
        //            db.UserList.Add(userList);
        //            db.SaveChanges();

        //            MessageBox.Show("Save");

        //        }
        //    }
        //    catch (Exception EX)
        //    {
        //        MessageBox.Show(EX.ToString());
        //    }
        //}

        public void SaveDatosUser(UserList user)
        {
            try
            {
                using (programacionEntities db = new programacionEntities())
                {

                    UserList userList = new UserList();

                    userList.NombreUsuario = user.NombreUsuario;
                    userList.Apellido = user.Apellido;
                    userList.Edad = user.Edad;
                    userList.Pass = user.Pass;
                    db.UserList.Add(userList);
                    db.SaveChanges();

                    MessageBox.Show("Save");

                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }

        public void DeleteUser(int ID)
        {

            try
            {
                using (programacionEntities db = new programacionEntities())
                {

                    int Eliminar = Convert.ToInt32(ID);
                    UserList userList = db.UserList.Where(x => x.Id == Eliminar).Select(x => x).FirstOrDefault();
                    //userList = db.UserList.Find(Eliminar);
                    db.UserList.Remove(userList);
                    db.SaveChanges();

                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }

        }

        public void UpdateUser(UserList user)
        {

            try
            {
                using (programacionEntities db = new programacionEntities())
                {
                    int Update = Convert.ToInt32(user.Id);
                    UserList userList = db.UserList.Where(x => x.Id == Update).Select(x => x).FirstOrDefault();
                    //UserList userList1 = new UserList();
                    //userList1 = db.UserList.Find();
                    userList.NombreUsuario = user.NombreUsuario;
                    userList.Apellido = user.Apellido;
                    userList.Edad = user.Edad;
                    userList.Pass = user.Pass;
                    db.SaveChanges();

                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }

        }
    }
}
