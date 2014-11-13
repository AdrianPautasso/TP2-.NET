using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Logic;
using Business.Entities;


namespace UI.Consola
{
    public class Usuario
    {
        private UsuarioLogic usuarioNegocio;

        public Usuario()
        {
            UsuarioLogic UsuarioNegocio = new UsuarioLogic();
        }

        public UsuarioLogic UsuarioNegocio
        {
            get
            {
                return usuarioNegocio;
            }
            set
            {
                usuarioNegocio = value;
            }
        }

        public void Menu()
        {
            Boolean continuar = true;
            do
            {
                Console.Clear();
                Console.WriteLine("1– Listado General\n2– Consulta\n3– Agregar\n4- Modificar\n5- Eliminar\n6- Salir");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        this.ListadoGeneral();
                        break;
                    case 2:
                        this.Consultar();
                        break;
                    case 3:
                        this.Agregar();
                        break;
                    case 4:
                        this.Modificar();
                        break;
                    case 5:
                        this.Eliminar();
                        break;
                    case 6:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta, presione enter.");
                        Console.ReadKey();
                        break;
                }
            } while (continuar == true);
        }

        public void ListadoGeneral()
        {
            Console.Clear();
            foreach (Business.Entities.Usuario usr in UsuarioNegocio.GetAll())
            {
                MostrarDatos(usr);
            }
        }

        public void MostrarDatos(Business.Entities.Usuario usr)
        {
            Console.WriteLine("Usuario: {0}", usr.ID);
            //Console.WriteLine("\t\tNombre: {0}", usr.Nombre);
            //Console.WriteLine("\t\tApellido: {0}", usr.Apellido);
            Console.WriteLine("\t\tNombre de Usuario: {0}", usr.NombreUsuario);
            Console.WriteLine("\t\tClave: {0}", usr.Clave);
            //Console.WriteLine("\t\tEmail: {0}", usr.EMail);
            Console.WriteLine("\t\tNombre: {0}", usr.Habilitado);
            Console.WriteLine();
        }

        public void Consultar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese ID del usuario a consultar: ");
                int ID = int.Parse(Console.ReadLine());
                this.MostrarDatos(UsuarioNegocio.GetOne(ID));
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("La ID ingresada debe ser un número entero\n");
            }
            catch (Exception h)
            {
                Console.WriteLine(h.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }

        public void Modificar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el ID del usuarioNegocio a modificar: ");
                int ID = int.Parse(Console.ReadLine());
                Business.Entities.Usuario usuario = UsuarioNegocio.GetOne(ID);
                Console.WriteLine("Ingrese Nombre: ");
                //usuario.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese Apellido: ");
                //usuario.Apellido = Console.ReadLine();
                Console.WriteLine("Ingrese Nombre de Usuario: ");
                usuario.NombreUsuario = Console.ReadLine();
                Console.WriteLine("Ingrese Clave: ");
                usuario.Clave = Console.ReadLine();
                Console.WriteLine("Ingrese Email: ");
                //usuario.EMail = Console.ReadLine();
                Console.WriteLine("Ingrese Habilitacion de Usuario (1-Si/otro - No): ");
                usuario.Habilitado = (Console.ReadLine() == "1");
                usuario.State = BusinessEntity.States.Modified;
                UsuarioNegocio.Save(usuario);
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine(fe.Message);
                Console.WriteLine("La ID ingresada debe ser un número entero");
            }
            catch (Exception h)
            {
                Console.WriteLine(h.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }

        public void Agregar()
        {
            Business.Entities.Usuario usuario = new Business.Entities.Usuario();
            Console.Clear();
            Console.WriteLine("Ingrese Nombre: ");
            //usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Apellido: ");
            //usuario.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese Nombre de Usuario: ");
            usuario.NombreUsuario = Console.ReadLine();
            Console.WriteLine("Ingrese Clave: ");
            usuario.Clave = Console.ReadLine();
            Console.WriteLine("Ingrese Email: ");
            //usuario.EMail = Console.ReadLine();
            Console.WriteLine("Ingrese Habilitacion de Usuario (1-Si/otro - No): ");
            usuario.Habilitado = (Console.ReadLine() == "1");
            usuario.State = BusinessEntity.States.New;
            UsuarioNegocio.Save(usuario);
            Console.WriteLine();
            Console.WriteLine("ID: {0}", usuario.ID);
        }

        public void Eliminar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese ID del usuarioNegocio a eliminar");
                int ID = int.Parse(Console.ReadLine());
                UsuarioNegocio.Delete(ID);
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine(fe.Message);
                Console.WriteLine("La ID ingresada debe ser un número entero");
            }
            catch (Exception h)
            {
                Console.WriteLine();
                Console.WriteLine(h.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }

        }
    }
}