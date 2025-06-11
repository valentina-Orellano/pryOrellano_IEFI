﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace pryOrellano_IEFI
{
    public class clsConexion
    {
        public string cadenaConexion;
        public clsConexion()
        {
            cadenaConexion = "Server=localhost;Database=TrabajoIEFI;Trusted_Connection=True;";
        }

         public int Iniciar(clsUsuario Iniciar)
        {
            int idUsuario = 0;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = "SELECT IdUsuario, Rol FROM Usuarios WHERE Usuario = @Usuario AND Contraseña = @Contraseña";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@Usuario", Iniciar.Usuario);
                    comando.Parameters.AddWithValue("@Contraseña", Iniciar.Contraseña);

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idUsuario = reader.GetInt32(0); 
                            Iniciar.Rol = reader.GetString(1); 

                            reader.Close(); 
                           
                            reader.Close();

                            string updateQuery = "UPDATE Usuarios SET UltimaConexion = @UltimaConexion WHERE IdUsuario = @IdUsuario";
                            SqlCommand updateCommand = new SqlCommand(updateQuery, conexion);
                            updateCommand.Parameters.AddWithValue("@UltimaConexion", DateTime.Now);
                            updateCommand.Parameters.AddWithValue("@IdUsuario", idUsuario);
                            updateCommand.ExecuteNonQuery();
                            ActualizarEstado(Iniciar.Usuario, "Activo");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en inicio de sesión: " + ex.Message);
            }

            return idUsuario;
         }

        public int AgregarUsuario(clsUsuario Usuario)
        {
            int nuevoIdUsuario = 0;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = "INSERT INTO Usuarios (Usuario, Contraseña) VALUES (@Usuario, @Contraseña); SELECT SCOPE_IDENTITY();";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@Usuario", Usuario.Usuario);
                    comando.Parameters.AddWithValue("@Contraseña", Usuario.Contraseña);

                    object resultado = comando.ExecuteScalar();
                    nuevoIdUsuario = Convert.ToInt32(resultado);

                  
                    string queryU = "UPDATE Usuarios SET UltimaConexion = @UltimaConexion WHERE IdUsuario = @IdUsuario";
                    SqlCommand comandoU = new SqlCommand(queryU, conexion);
                    comandoU.Parameters.AddWithValue("@UltimaConexion", DateTime.Now);
                    comandoU.Parameters.AddWithValue("@IdUsuario", nuevoIdUsuario);
                    comandoU.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el usuario: " + ex.Message);
            }

            return nuevoIdUsuario;
        }

        public void ActualizarEstado(string usuario, string estado)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "UPDATE Usuarios SET Estado = @Estado WHERE Usuario = @Usuario";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@Estado", estado);
                    comando.Parameters.AddWithValue("@Usuario", usuario);
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el estado: " + ex.Message);
            }
        }

        public void GuardarUltimaConexion(string usuario, TimeSpan tiempoSesion)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                
                string query = "SELECT TiempoTotal FROM Usuarios WHERE Usuario = @Usuario";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Usuario", usuario);

                object resultado = comando.ExecuteScalar();
                TimeSpan tiempoTotalAnterior = TimeSpan.Zero;

                if (resultado != DBNull.Value && resultado != null)
                {
                    tiempoTotalAnterior = (TimeSpan)resultado;
                }

                TimeSpan nuevoTiempoTotal = tiempoTotalAnterior + tiempoSesion;

                
                string queryUpdate = @"
                 UPDATE Usuarios 
                 SET 
                 UltimaConexion = @FechaActual,              -- Fecha y hora actual
                 TiempoUltimaConexion = @TiempoSesion,       -- Duración de esta sesión
                 TiempoTotal = @TiempoTotal                  -- Acumulado total
                 WHERE Usuario = @Usuario";

                SqlCommand comandoA = new SqlCommand(queryUpdate, conexion);
                comandoA.Parameters.AddWithValue("@FechaActual", DateTime.Now);
                comandoA.Parameters.AddWithValue("@TiempoSesion", tiempoSesion);
                comandoA.Parameters.AddWithValue("@TiempoTotal", nuevoTiempoTotal);
                comandoA.Parameters.AddWithValue("@Usuario", usuario);

                comandoA.ExecuteNonQuery();
            }


        }

        public void CargarUsuarios(DataGridView dgv)
        {
            try
            {
                string query = "SELECT IdUsuario, Usuario, Contraseña, Rol, FechaCreacion, Dirección, DNI, Teléfono, Gmail, Estado FROM Usuarios";

                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);
                    dgv.DataSource = tabla;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }

        }
        public void Agregar(clsUsuario Usuario)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "INSERT INTO Usuarios (Usuario, Contraseña, Rol, FechaCreacion, UltimaConexion, TiempoUltimaConexion,TiempoTotal, Estado) " +
                                   "VALUES (@Usuario, @Contraseña, @Rol, @FechaCreacion, @UltimaConexion, @TiempoUltimaConexion, @TiempoTotal, @Estado)";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@Usuario", Usuario.Usuario);
                    comando.Parameters.AddWithValue("@Contraseña", Usuario.Contraseña);
                    comando.Parameters.AddWithValue("@Rol", Usuario.Rol);
                    comando.Parameters.AddWithValue("@Dirección", Usuario.Dirección);
                    comando.Parameters.AddWithValue("@DNI", Usuario.DNI);
                    comando.Parameters.AddWithValue("@Teléfono", Usuario.Teléfono);
                    comando.Parameters.AddWithValue("@Gmail", Usuario.Gmail);

                    comando.Parameters.AddWithValue("@Estado", Usuario.Estado);
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el usuario: " + ex.Message);
            }
        }

        public void Modificar(clsUsuario Usuario)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "UPDATE Usuarios SET Usuario=@Usuario, Contraseña=@Contraseña, Rol= @Rol, FechaCreacion=@FechaCreacion, UltimaConexion=@UltimaConexion, TiempoUltimaConexion=@TiempoUltimaConexion,TiempoTotal=@TiempoTotal, Estado=@Estado WHERE IdUsuario=@IdUsuario ";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@Usuario", Usuario.Usuario);
                    comando.Parameters.AddWithValue("@Contraseña", Usuario.Contraseña);
                    comando.Parameters.AddWithValue("@Rol", Usuario.Rol);
                    comando.Parameters.AddWithValue("@Dirección", Usuario.Dirección);
                    comando.Parameters.AddWithValue("@DNI", Usuario.DNI);
                    comando.Parameters.AddWithValue("@Teléfono", Usuario.Teléfono);
                    comando.Parameters.AddWithValue("@Gmail", Usuario.Gmail);
                    comando.Parameters.AddWithValue("@Estado", Usuario.Estado);
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el usuario: " + ex.Message);
            }
        }
        public void Eliminar(clsUsuario Usuario)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "DELETE FROM Usuarios WHERE Usuario=@Usuario";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@Usuario", Usuario.Usuario);

                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
            }
        }
        public clsUsuario CargarSoloEsteUsuario(string nombreUsuario)
        {
            clsUsuario usuario = null;
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = "SELECT * FROM Usuarios WHERE Usuario = @Usuario";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Usuario", nombreUsuario);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    usuario = new clsUsuario
                    {
                        Usuario = reader["Usuario"].ToString(),
                        Contraseña = reader["Contraseña"].ToString(),
                        
                    };
                }
            }
            return usuario;
        }

        public void CargarTarea(DataGridView dgv)
        {
            try
            {
                string query = "SELECT IdUsuario, Usuario, Fecha, TareaId, LugarId, Insumo, Estudio, Vacaciones, Enfermedad, Salario, Recibo, Comentario  FROM Tareas";

                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);
                    dgv.DataSource = tabla;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }

        }

        public void GrabarTarea(clsTarea Tarea)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "INSERT INTO Tareas (IdUsuario, Usuario, Fecha, TareaId, LugarId, Insumo, Estudio, Vacaciones, Enfermedad, Salario, Recibo, Comentario) " +
                                   "VALUES (@IdUsuario, @Usuario, @Fecha, @TareaId, @LugarId, @Insumo, @Estudio, @Vacaciones, @Enfermedad, @Salario, @Recibo, @Comentario)";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    //comando.Parameters.AddWithValue("@IdTarea", Tarea.IdTarea);
                    comando.Parameters.AddWithValue("@IdUsuario", Tarea.IdUsuario);
                    comando.Parameters.AddWithValue("@Usuario", Tarea.Usuario);
                    comando.Parameters.AddWithValue("@Fecha", Tarea.Fecha);
                    comando.Parameters.AddWithValue("@TareaId", Tarea.TareaId);
                    comando.Parameters.AddWithValue("@LugarId", Tarea.LugarId);
                    comando.Parameters.AddWithValue("@Insumo", Tarea.Insumo);
                    comando.Parameters.AddWithValue("@Estudio", Tarea.Estudio);
                    comando.Parameters.AddWithValue("@Vacaciones", Tarea.Vacaciones);
                    comando.Parameters.AddWithValue("@Enfermedad", Tarea.Enfermedad);
                    comando.Parameters.AddWithValue("@Salario", Tarea.Salario);
                    comando.Parameters.AddWithValue("@Recibo", Tarea.Recibo);
                    comando.Parameters.AddWithValue("@Comentario", Tarea.Comentario);


                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la tarea: " + ex.Message);
            }
        }

        public void AgregarTareaTipo(string nombre)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "INSERT INTO TareasTipo (Nombre) VALUES (@Nombre)";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la tarea: " + ex.Message);
            }

        }

        public void AgregarLugar(string nombre)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "INSERT INTO Lugar (Nombre) VALUES (@Nombre)";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el lugar: " + ex.Message);
            }

        }
    }
}
