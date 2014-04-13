using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace iTEC_Cireseii
{
    /// <summary>
    /// Comenzile de operare a bazei de date online MySQL
    /// </summary>
    static class MySQL
    {
        static private MySqlConnection connection = new MySqlConnection(FileOperations.ExtractConnectionFromFile("config.cfg"));
        /// <summary>
        /// Verificarea existentei datelor utilizatorilor
        /// </summary>
        /// <param name="_user"></param>
        /// <param name="_pass"></param>
        /// <returns></returns>
        static public bool VerifyUser(string _user, string _pass)
        {
            try
            {
                MySqlCommand commandSelect = new MySqlCommand("SELECT * FROM Users WHERE Username=@username AND Password=@password", connection);
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                commandSelect.Parameters.AddWithValue("@username", _user);
                commandSelect.Parameters.AddWithValue("@password", _pass);
                if (commandSelect.ExecuteScalar() != null)
                {
                    commandSelect.Parameters.Clear();
                    return true;
                }
                else
                {
                    commandSelect.Parameters.Clear();
                    return false;
                }
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return false;
            }
        }
        /// <summary>
        /// Verificarea tipului utilizatorului : Fie user normal Fie Admin
        /// </summary>
        /// <param name="_user"></param>
        /// <param name="_pass"></param>
        /// <returns></returns>
        static public string GetUserType(string _user, string _pass)
        {
            string tip = "";
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand commandSelectTip = new MySqlCommand("SELECT Type FROM Users WHERE Username=@username AND Password=@password", connection);
                commandSelectTip.Parameters.AddWithValue("@username", _user);
                commandSelectTip.Parameters.AddWithValue("@password", _pass);
                tip = (string)commandSelectTip.ExecuteScalar();
                commandSelectTip.Parameters.Clear();
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
            return tip;
        }
        /// <summary>
        /// Importarea de Grupe din Baza de date
        /// </summary>
        /// <returns></returns>
        static public List<string> GetGroups()
        {
            List<string> groups = new List<string>();
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand commandSelectGroups = new MySqlCommand("SELECT DISTINCT Name FROM ProductGroups", connection);
                MySqlDataReader mySqlDataReader = commandSelectGroups.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    groups.Add((string)mySqlDataReader["Name"]);
                }
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
            return groups;
        }
        /// <summary>
        /// Importarea de Puncte din Baza de date
        /// </summary>
        /// <param name="_user"></param>
        /// <returns></returns>
        static public int GetUserPoints(string _user)
        {
            int result = 0;
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand commandSelect = new MySqlCommand("SELECT Points FROM Users WHERE Username=@user", connection);
                commandSelect.Parameters.AddWithValue("@user", _user);
                result = (int)commandSelect.ExecuteScalar();
                commandSelect.Parameters.Clear();
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
        /// <summary>
        /// Popularea unui tabel cu iteme din baza de date ONLINE
        /// </summary>
        /// <returns></returns>
        static public List<Item> GetItems()
        {
            List<Item> items = new List<Item>();
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand commandSelect = new MySqlCommand("SELECT * FROM Products", connection);
                MySqlDataReader dataReader = commandSelect.ExecuteReader();
                while (dataReader.Read())
                {
                    Item item = new Item();
                    item.Name = (string)dataReader["Name"];
                    item.Points = (int)dataReader["Points"];
                    item.Group = (string)dataReader["Groups"];
                    item.ImageLocation = (string)dataReader["ImageLocation"];
                    items.Add(item);
                }
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
            return items;
        }
        /// <summary>
        /// Adaugarea unui nou utilizator in baza de date
        /// </summary>
        /// <param name="_userName"></param>
        /// <param name="password"></param>
        /// <param name="groups"></param>
        /// <param name="points"></param>
        /// <param name="type"></param>
        /// <param name="language"></param>
        static public void InsertUser(string _userName, string password, int points, string type, string language)
        {            
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand commandInsertUser = new MySqlCommand("INSERT INTO Users(Username, Password,Groups, Points, Type) VALUES(@username, @password,@groups, @points, @type)", connection);
                commandInsertUser.Parameters.AddWithValue("@username", _userName);
                commandInsertUser.Parameters.AddWithValue("@password", password);
                commandInsertUser.Parameters.AddWithValue("@groups", "");
                commandInsertUser.Parameters.AddWithValue("@points", points);
                commandInsertUser.Parameters.AddWithValue("@type", type);
                commandInsertUser.ExecuteNonQuery();
                if (language == "ro")
                    MessageBox.Show("Utilizator adăugat cu succes!"); 
                else 
                    MessageBox.Show("User has been successfully added!");
                commandInsertUser.Parameters.Clear();
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Adaugarea unui nou produs in baza de date
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Groups"></param>
        /// <param name="Points"></param>
        /// <param name="ImageLocation"></param>
        /// <param name="language"></param>
        static public void InsertProduct(string Name, string Groups, int Points, string ImageLocation, string language)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand commandInsertProduct = new MySqlCommand("INSERT INTO Products(Name, Groups, Points, ImageLocation) VALUES (@name, @groups, @points, @imageLocation)", connection);
                commandInsertProduct.Parameters.AddWithValue("@name", Name);
                commandInsertProduct.Parameters.AddWithValue("@groups", Groups);
                commandInsertProduct.Parameters.AddWithValue("@points", Points);
                commandInsertProduct.Parameters.AddWithValue("@imageLocation", ImageLocation);
                commandInsertProduct.ExecuteNonQuery();
                if (language == "ro") 
                    MessageBox.Show("Delicatesă adăugat cu succes!"); 
                else  
                    MessageBox.Show("Delight has been successfully added!");
                commandInsertProduct.Parameters.Clear();
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Adaugarea voturilor efectuate in baza de date ONLINE
        /// </summary>
        /// <param name="_username"></param>
        /// <param name="_votedProduct"></param>
        /// <param name="_votedProductPoints"></param>
        /// <param name="_data"></param>
        static public void InsertVote(string _username, string _votedProduct, int _votedProductPoints, string _data)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand commandInsert = new MySqlCommand("INSERT INTO Votes(Username,VotedProduct,VotedProductPoints,Data) VALUES(@username,@votedProduct,@votedProductPoints,@data)", connection);
                commandInsert.Parameters.AddWithValue("@username", _username);
                commandInsert.Parameters.AddWithValue("@votedProduct", _votedProduct);
                commandInsert.Parameters.AddWithValue("@votedProductPoints", _votedProductPoints);
                commandInsert.Parameters.AddWithValue("@data", DateTime.Parse(_data).ToLocalTime().ToShortDateString());
                commandInsert.ExecuteNonQuery();
                commandInsert.Parameters.Clear();
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Dupa ce o votat, utilizatorului i se incarca 0 puncte,consumandu-si voturile
        /// </summary>
        /// <param name="_username"></param>
        static public void UpdateUserVote(string _username)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand commandUpdate = new MySqlCommand("UPDATE Users SET Points = @points WHERE Username=@username", connection);
                commandUpdate.Parameters.AddWithValue("@points", 0);
                commandUpdate.Parameters.AddWithValue("@username", _username);
                commandUpdate.ExecuteNonQuery();
                commandUpdate.Parameters.Clear();
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Clone();
            }
        }
        /// <summary>
        /// Selectarea datelor produselor/delicateselor din baza de date online
        /// </summary>
        /// <param name="_id"></param>
        /// <returns></returns>
        static public string[] GetProductsData(int _id)
        {
            string[] productsData = new string[4];
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand commandSelect = new MySqlCommand("SELECT Name,Groups,Points,ImageLocation FROM Products WHERE ID=@id", connection);
                commandSelect.Parameters.AddWithValue("@id", _id);
                MySqlDataReader dataReader = commandSelect.ExecuteReader();
                while (dataReader.Read())
                {
                    productsData[0] = (string)dataReader[0];
                    productsData[1] = (string)dataReader[1];
                    productsData[2] = ((int)dataReader[2]).ToString();
                    productsData[3] = (string)dataReader[3];
                }
                dataReader.Close();
                commandSelect.Parameters.Clear();
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
            return productsData;
        }
        /// <summary>
        /// Selectarea datelor utilizatorilor din baza de date online
        /// </summary>
        /// <param name="_id"></param>
        /// <returns></returns>
        static public string[] GetUserData(int _id)
        {
            string[] userData = new string[5];
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand commandSelect = new MySqlCommand("SELECT * FROM Users WHERE ID=@id", connection);
                commandSelect.Parameters.AddWithValue("@id", _id);
                MySqlDataReader dataReader = commandSelect.ExecuteReader();
                while (dataReader.Read())
                {
                    userData[0] = (string)dataReader["Username"];
                    userData[1] = (string)dataReader["Password"];
                    userData[2] = (string)dataReader["Groups"];
                    userData[3] = ((int)dataReader["Points"]).ToString();
                    userData[4] = (string)dataReader["Type"];
                }
                dataReader.Close();
                commandSelect.Parameters.Clear();
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Clone();
            }
            return userData;
        }
        /// <summary>
        /// Construirea Listei cu Numele Grupelor din tabelul UsersGroups
        /// </summary>
        /// <returns></returns>
        static public List<string> GetUsersGroups()
        {
            List<string> userGroups = new List<string>();
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand commandSelect = new MySqlCommand("SELECT Name FROM UsersGroups", connection);
                MySqlDataReader dataReader = commandSelect.ExecuteReader();
                while (dataReader.Read())
                {
                    userGroups.Add((string)dataReader[0]);
                }
                dataReader.Close();
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
            return userGroups;
        }
        /// <summary>
        /// Schimbarea datelor unui anumit User
        /// </summary>
        /// <param name="_id"></param>
        /// <param name="_username"></param>
        /// <param name="_password"></param>
        /// <param name="_groups"></param>
        /// <param name="_points"></param>
        /// <param name="_type"></param>
        static public void UpdateUserData(int _id,string _username, string _password, string _groups, int _points, string _type)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand commandInsert = new MySqlCommand("UPDATE Users SET Username=@username,Password=@password,Groups=@groups,Points=@points,Type=@type WHERE ID=@id", connection);
                commandInsert.Parameters.AddWithValue("@username", _username);
                commandInsert.Parameters.AddWithValue("@password", _password);
                commandInsert.Parameters.AddWithValue("@groups", _groups);
                commandInsert.Parameters.AddWithValue("@points", _points);
                commandInsert.Parameters.AddWithValue("@type", _type);
                commandInsert.Parameters.AddWithValue("@id", _id);
                commandInsert.ExecuteNonQuery();
                commandInsert.Parameters.Clear();
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Clone();
            }
        }
        /// <summary>
        /// Schimbarea datelor unui anumit produs/delicatesa
        /// </summary>
        /// <param name="_id"></param>
        /// <param name="_name"></param>
        /// <param name="_groups"></param>
        /// <param name="_points"></param>
        /// <param name="_imageLocation"></param>
        static public void UpdateProductsData(int _id, string _name, string _groups, int _points, string _imageLocation)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand commandUpdate = new MySqlCommand("UPDATE Products SET Name=@name,Groups=@groups,Points=@points,ImageLocation=@imageLocation WHERE ID=@id",connection);
                commandUpdate.Parameters.AddWithValue("@name",_name);
                commandUpdate.Parameters.AddWithValue("@groups",_groups);
                commandUpdate.Parameters.AddWithValue("@points",_points);
                commandUpdate.Parameters.AddWithValue("@imageLocation",_imageLocation);
                commandUpdate.Parameters.AddWithValue("@id",_id);
                commandUpdate.ExecuteNonQuery();
                commandUpdate.Parameters.Clear();
            }
            catch(MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Construirea comenzii de incarcare a tabelului
        /// </summary>
        /// <param name="_dataGridView"></param>
        static public void Refresh(DataGridView _dataGridView)
        {
            try
            {
                if(connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT ID,Username FROM Users", connection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                _dataGridView.DataSource = dataTable;
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Construirea comenzii de stergere a informatiilor din tabel
        /// </summary>
        /// <param name="_userName"></param>
        static public void DeleteUser(int _id)
        {
            try
            {
                if(connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand commandDelete = new MySqlCommand("DELETE FROM Users WHERE ID=@id", connection);
                commandDelete.Parameters.AddWithValue("@id", _id);
                commandDelete.ExecuteNonQuery();
                commandDelete.Parameters.Clear();
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Comanda de stergere a unei delicatese din tabel
        /// </summary>
        /// <param name="_id"></param>
        static public void DeleteProduct(int _id)
        {
            try
            {
                connection.Open();
                MySqlCommand commandDelete = new MySqlCommand("DELETE FROM Products WHERE ID=@id", connection);
                commandDelete.Parameters.AddWithValue("@id", _id);
                commandDelete.ExecuteNonQuery();
                commandDelete.Parameters.Clear();
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Stergerea unui grup de utilizatori
        /// </summary>
        /// <param name="_name"></param>
        static public void DeleteUsersGroups(string _name)
        {
            try
            {
                connection.Open();
                MySqlCommand commandDelete = new MySqlCommand("DELETE FROM UsersGroups WHERE Name=@name", connection);
                commandDelete.Parameters.AddWithValue("@name", _name);
                commandDelete.ExecuteNonQuery();
                commandDelete.Parameters.Clear();
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Cautarea unor date in tabelul de utilizatori, pentru a le inlocui 
        /// </summary>
        /// <param name="_dataGridView"></param>
        /// <param name="_user"></param>
        static public void Search(DataGridView _dataGridView, string _user)
        {
            try
            {
                connection.Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT ID,Username FROM Users WHERE Username like '" + _user + "%' ", connection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                _dataGridView.DataSource = dataTable;
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Cautarea unor date in tabelul de produse, pentru a le inlocui
        /// </summary>
        /// <param name="_dataGridView"></param>
        /// <param name="_product"></param>       
        static public void SearchProduct(DataGridView _dataGridView, string _product)
        {
            try
            {
                connection.Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT ID,Name FROM Products WHERE Name like '" + _product + "%' ", connection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                _dataGridView.DataSource = dataTable;
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Actualizarea grilei de vizualizare a produselor
        /// </summary>
        /// <param name="_dataGridView"></param>
        static public void RefreshProduct(DataGridView _dataGridView)
        {
            try
            {
                if(connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT ID,Name FROM Products", connection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                _dataGridView.DataSource = dataTable;
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Adaugarea unor noi grupe de delicatese in tabelul de produse/delicatese
        /// </summary>
        /// <param name="_groupName"></param>
        static public void InsertDelightGroups(string _groupName,string language)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand commandInsertDelightGroups = new MySqlCommand("INSERT INTO ProductGroups(Name) VALUES (@name)", connection);
                commandInsertDelightGroups.Parameters.AddWithValue("@name", _groupName);
                commandInsertDelightGroups.ExecuteNonQuery();
                if (language == "ro")
                    MessageBox.Show("Grupa delicatesei adăugată cu succes!");
                else
                    MessageBox.Show("Delight Group has been successfully added!");
                commandInsertDelightGroups.Parameters.Clear();
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Actualizarea Grupelor Produselor
        /// </summary>
        /// <param name="_groupName"></param>
        /// <param name="_initialName"></param>
        /// <param name="_modifyProducts"></param>
        static public void UpdateProductGroups(string _groupName,string _initialName, bool _modifyProducts)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand commandUpdateProductGroups = new MySqlCommand("UPDATE ProductGroups SET Name=@name WHERE Name=@initialName ", connection);
                commandUpdateProductGroups.Parameters.AddWithValue("@name", _groupName);
                commandUpdateProductGroups.Parameters.AddWithValue("@initialName", _initialName);
                commandUpdateProductGroups.ExecuteNonQuery();
                commandUpdateProductGroups.Parameters.Clear();
                if (_modifyProducts)
                {
                    commandUpdateProductGroups = new MySqlCommand("UPDATE Products SET Groups=@newGroup WHERE Groups=@oldGroup",connection);
                    commandUpdateProductGroups.Parameters.AddWithValue("@newGroup",_groupName);
                    commandUpdateProductGroups.Parameters.AddWithValue("@oldGroup", _initialName);
                    commandUpdateProductGroups.ExecuteNonQuery();
                    commandUpdateProductGroups.Parameters.Clear();
                }
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Actualizarrea Grupelor de utilizatori
        /// </summary>
        /// <param name="_groupName"></param>
        /// <param name="_initialName"></param>
        /// <param name="_modifyProducts"></param>
        static public void UpdateUsersGroups(string _groupName, string _initialName, bool _modifyProducts)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand commandUpdateProductGroups = new MySqlCommand("UPDATE UsersGroups SET Name=@newName WHERE Name=@initialName", connection);
                commandUpdateProductGroups.Parameters.AddWithValue("@newName", _groupName);
                commandUpdateProductGroups.Parameters.AddWithValue("@initialName", _initialName);
                commandUpdateProductGroups.ExecuteNonQuery();
                commandUpdateProductGroups.Parameters.Clear();
                if (_modifyProducts)
                {
                    commandUpdateProductGroups = new MySqlCommand("UPDATE Users SET Groups=@newGroup WHERE Groups=@oldGroup", connection);
                    commandUpdateProductGroups.Parameters.AddWithValue("@newGroup", _groupName);
                    commandUpdateProductGroups.Parameters.AddWithValue("@oldGroup", _initialName);
                    commandUpdateProductGroups.ExecuteNonQuery();
                    commandUpdateProductGroups.Parameters.Clear();
                }
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Adaugarea unei noi grupe in tabelul de utilizatori
        /// </summary>
        /// <param name="_name"></param>
        static public void AddUserGroup(string _name, int _points)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand commandInsert = new MySqlCommand("INSERT INTO UsersGroups(Name,Points) VALUES(@name,@points)", connection);
                commandInsert.Parameters.AddWithValue("@name", _name);
                commandInsert.Parameters.AddWithValue("@points", _points);
                commandInsert.ExecuteNonQuery();
                commandInsert.Parameters.Clear();
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Stergerea unei grupe de Produse/Delicatese
        /// </summary>
        /// <param name="_name"></param>
        static public void DeleteProductGroup(string _name)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand commandInsert = new MySqlCommand("DELETE FROM ProductGroups WHERE Name=@name", connection);
                commandInsert.Parameters.AddWithValue("@name", _name);
                commandInsert.ExecuteNonQuery();
                commandInsert.Parameters.Clear();

            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Construirea unei liste de nume de utilizatori votanti pentru vot
        /// </summary>
        /// <returns></returns>
        static public List<string> GetUsers()
        {
            List<string> user = new List<string>();
            try
            { 
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand commandSelect = new MySqlCommand("SELECT Username FROM Users WHERE Type='user'", connection);
                MySqlDataReader dataReader = commandSelect.ExecuteReader();
                while (dataReader.Read())
                    user.Add((string)dataReader[0]);
                dataReader.Close();
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
            return user;
        }
        /// <summary>
        /// Aflarea numarului total de puncte pentru fiecare grup de utilizatori
        /// </summary>
        /// <param name="_name"></param>
        /// <returns></returns>
        static public int GetUsersGroupsPoints(string _name)
        {
            int result = -1;
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand commandInsert = new MySqlCommand("SELECT Points FROM UsersGroups WHERE Name=@name", connection);
                commandInsert.Parameters.AddWithValue("@name", _name);
                result = (int)commandInsert.ExecuteScalar();
                commandInsert.Parameters.Clear();
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
        /// <summary>
        /// Trecerea utilizatorilor de la o grupa la alta si schimbarea numarului de puncte specific fiecarui votant
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_group"></param>
        /// <param name="_points"></param>
        /// <param name="_changePoints"></param>
        static public void SetUsersGroupAndPoints(string _name, string _group, int _points, bool _changePoints)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                if (_changePoints)
                {
                    MySqlCommand commandUpdate = new MySqlCommand("UPDATE Users SET Groups=@group,Points=@points WHERE Username=@username", connection);
                    commandUpdate.Parameters.AddWithValue("@group", _group);
                    commandUpdate.Parameters.AddWithValue("@points", _points);
                    commandUpdate.Parameters.AddWithValue("@username", _name);
                    commandUpdate.ExecuteNonQuery();
                    commandUpdate.Parameters.Clear();
                }
                else
                {
                    MySqlCommand commandUpdate = new MySqlCommand("UPDATE Users SET Groups=@group WHERE Username=@username", connection);
                    commandUpdate.Parameters.AddWithValue("@group", _group);
                    commandUpdate.Parameters.AddWithValue("@username", _name);
                    commandUpdate.ExecuteNonQuery();
                    commandUpdate.Parameters.Clear();
                }
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Setarea Numarului de puncte pentru fiecare grupa
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_points"></param>
        static public void SetGroupsPoints(string _name, int _points)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand commandUpdate = new MySqlCommand("UPDATE UsersGroups SET Points=@points WHERE Name=@name", connection);
                commandUpdate.Parameters.AddWithValue("@name", _name);
                commandUpdate.Parameters.AddWithValue("@points", _points);
                commandUpdate.ExecuteNonQuery();
                commandUpdate.Parameters.Clear();
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Selectarea Utilizatorilor in functie de grupele lor
        /// </summary>
        /// <param name="_groups"></param>
        /// <returns></returns>
        static public List<string> SelectUsersByGroups(string _groups)
            {
                List<string> users = new List<string>();
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand commandSelectGroups = new MySqlCommand("SELECT Username FROM Users WHERE Groups=@groups", connection);
                commandSelectGroups.Parameters.AddWithValue("@groups",_groups);
                MySqlDataReader mySqlDataReader = commandSelectGroups.ExecuteReader();  
                while (mySqlDataReader.Read())
                {
                    users.Add((string)mySqlDataReader["Username"]);
                }
                mySqlDataReader.Close();
                commandSelectGroups.Parameters.Clear();
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }

            return users;
            }
        /// <summary>
        /// Calcularea numarului total de voturi
        /// </summary>
        /// <returns></returns>
        static public int GetTotalVotes()
        {
            int sum = 0;
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand commandSelect = new MySqlCommand("SELECT VotedProductPoints FROM Votes", connection);
                MySqlDataReader dataReader = commandSelect.ExecuteReader();
                while (dataReader.Read())                
                    sum += (int)dataReader[0];                
                dataReader.Close();
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
            return sum;
        }
        /// <summary>
        /// Luarea numelor produselor votate pentru realizarea raportului
        /// </summary>
        /// <returns></returns>
        static public string[] GetVotedProducts()
        {
            string[] products = null;
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand commandSelect = new MySqlCommand("SELECT DISTINCT VotedProduct FROM Votes", connection);
                MySqlDataReader dataReader = commandSelect.ExecuteReader();
                int count = 0;
                while (dataReader.Read())
                {
                    count++;
                }
                dataReader.Close();
                products = new string[count];
                commandSelect = new MySqlCommand("SELECT DISTINCT VotedProduct FROM Votes", connection);
                dataReader = commandSelect.ExecuteReader();
                count = -1;
                while (dataReader.Read())
                {
                    count++;
                    products[count] = (string)dataReader[0];
                }
                dataReader.Close();
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
            return products;
        }
        /// <summary>
        /// Aflarea numarului de voturi pentru fiecare produs/delicatesa
        /// </summary>
        /// <param name="_product"></param>
        /// <returns></returns>
        static public int GetVotesPerProduct(string _product)
        {
            int productSum = 0;
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand commandSelect = new MySqlCommand("SELECT VotedProductPoints FROM Votes WHERE VotedProduct=@product", connection);
                commandSelect.Parameters.AddWithValue("@product", _product);
                MySqlDataReader dataReader = commandSelect.ExecuteReader();
                while (dataReader.Read())
                {
                    productSum += (int)dataReader[0];
                }
                dataReader.Close();
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
            return productSum;
        }
        /// <summary>
        /// Afisarea ultimului mesaj lasat de admin pentru useri
        /// </summary>
        /// <returns></returns>
        static public string GetWelcomeMessage()
        {
            string message = "";
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand commandSelect = new MySqlCommand("SELECT MAX(ID) FROM WelcomeMessages", connection);
                int id = (int)commandSelect.ExecuteScalar();
                commandSelect = new MySqlCommand("SELECT Message FROM WelcomeMessages WHERE ID=@id",connection);
                commandSelect.Parameters.AddWithValue("@id", id);
                message = (string)commandSelect.ExecuteScalar();
                commandSelect.Parameters.Clear();
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Clone();
            }
            return message;
        }
        /// <summary>
        /// Inserarea Mesajului de Bun Venit
        /// </summary>
        /// <param name="_message"></param>
        static public void InsertWelcomeMessage(string _message)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand commandInsert = new MySqlCommand("INSERT INTO WelcomeMessages(Message) VALUES(@message)", connection);
                commandInsert.Parameters.AddWithValue("@message", _message);
                commandInsert.ExecuteNonQuery();
                commandInsert.Parameters.Clear();
                MessageBox.Show("The new message was introduced!");
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
        static public string GetUserLastVoteTime(string _user)
        {
            string date = "";
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand commandSelect = new MySqlCommand("SELECT MAX(ID) FROM Votes WHERE Username=@user", connection);
                commandSelect.Parameters.AddWithValue("@user", _user);
                int id = (int)commandSelect.ExecuteScalar();
                commandSelect.Parameters.Clear();
                commandSelect = new MySqlCommand("SELECT Data FROM Votes WHERE ID=@id", connection);
                commandSelect.Parameters.AddWithValue("@id", id);
                date = (string)commandSelect.ExecuteScalar();
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
            return date;
        }
        static public void ResetUserVote(string _user)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand commandSelect = new MySqlCommand("SELECT MAX(ID) FROM Votes WHERE Username=@user", connection);
                commandSelect.Parameters.AddWithValue("@user", _user);
                int id = (int)commandSelect.ExecuteScalar();
                commandSelect.Parameters.Clear();
                commandSelect = new MySqlCommand("SELECT Data FROM Votes WHERE ID=@id", connection);
                commandSelect.Parameters.AddWithValue("@id", id);
                string dateTime = (string)commandSelect.ExecuteScalar();
                commandSelect.Parameters.Clear();
                int initialPoints = 0;
                commandSelect = new MySqlCommand("SELECT VotedProductPoints FROM Votes WHERE Data=@data", connection);
                commandSelect.Parameters.AddWithValue("@data", dateTime);
                MySqlDataReader dataReader = commandSelect.ExecuteReader();
                while (dataReader.Read())
                {
                    initialPoints += (int)dataReader[0];
                }
                dataReader.Close();
                commandSelect = new MySqlCommand("UPDATE Users SET Points=@points WHERE Username=@username", connection);
                commandSelect.Parameters.AddWithValue("@points", initialPoints);
                commandSelect.Parameters.AddWithValue("@username", _user);
                commandSelect.ExecuteNonQuery();
                commandSelect.Parameters.Clear();
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
        static public int GetRegisteredUsers()
        {
            int sum = 0;
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand commandSelect = new MySqlCommand("SELECT Username FROM Users", connection);
                MySqlDataReader dataReader = commandSelect.ExecuteReader();
                while (dataReader.Read())
                    sum++;
                dataReader.Close();
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
            return sum;
        }
        
    }
}
