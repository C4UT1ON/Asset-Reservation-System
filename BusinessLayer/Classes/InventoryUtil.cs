using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer.Classes
{
    public class InventoryUtil
    {
        public InventoryUtil()
        { 
        }


        //non-static user defeine method returning a value
        public bool newAsset(Asset newAsset)
        {

            using (InventorydbEntities dbContext = new InventorydbEntities())
            {
                IEnumerable<Asset> result;
                try
                {
                    result = from asset in dbContext.Assets
                             where asset.Asset_id == newAsset.Asset_id
                             select asset;
                    

                    if (!result.Any())
                    {
                        dbContext.Assets.Add(newAsset);
                        dbContext.SaveChanges();
                        MessageBox.Show("Record Saved");
                        return true;
                    }                    
                    else
                    {
                        MessageBox.Show("A record with that ID already exists");
                        return false;
                    }

                }
                catch
                {
                   MessageBox.Show("Unable to communicate with Database or Access is denied");
                    return false;
                }

            }
        }


        //non-static user defeine method returning a value
        public bool loginAttempt(LoginAttempt loginDetails)
        {
            using (InventorydbEntities dbContext = new InventorydbEntities())
            {  
                
                IEnumerable<User> result;
                //try
                //{
                    //database access
                    result = from login in dbContext.Users
                            where login.User_username.Trim() == loginDetails.Username.Trim() && login.User_password.Trim() == loginDetails.Password.Trim()
                            select login;
                    
                    if (result.Any())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                //}
                //catch
                //{
                //    MessageBox.Show("not working");
                //    return false;
                //}
            }
        }


        //non-static user defeine method returning a value
        public bool createUser(User userDetails)
        {
            // using block assists with memory management for temporary objects
            using (InventorydbEntities dbContext = new InventorydbEntities())
            {
                IEnumerable<User> result;
                try
                {
                    //linq query-no sql required
                    result = from user in dbContext.Users
                             where user.User_username.Trim() == userDetails.User_username
                             select user;

                    if (!result.Any())
                    {
                        dbContext.Users.Add(userDetails);
                        dbContext.SaveChanges();
                        MessageBox.Show("Record Saved");
                        return true;
                    }
                    else
                    {
                        //validation
                        MessageBox.Show("A record with that username already exists");
                        return false;
                    }
                }
                catch
                {
                    //validation
                    MessageBox.Show("Unable to communicate with Database or Access is denied");
                    return false;
                }
            }
        }


        //static user defined method
        public static void reset(Form form)
        {
            foreach (Control item in form.Controls)
            {
                if (item is TextBox)
                {
                    item.ResetText();
                }
                    
            }
            
        }


        //static user defined method
        public static void getAssets(ComboBox list)
        {
            using (InventorydbEntities dbContext = new InventorydbEntities())
            {
                try
                {
                    //linq query-no sql required
                    var result = from asset in dbContext.Assets
                                 select asset.Asset_id;

                    foreach (string asset in result)
                    {
                        list.Items.Add(asset);
                    }
                }
                catch
                {
                    MessageBox.Show("not working");
                }
            }
        }

        //
        public static bool newReservation(Reservation details)
        {
            using (InventorydbEntities dbContext = new InventorydbEntities())
            {
                try
                {
                    IEnumerable<Asset> assetResult = from asset in dbContext.Assets
                                                     where
                                                     asset.Asset_id == details.Asset_AssetId
                                                     select asset;

                    if (assetResult.Any())
                    {
                        if (assetResult.First().Reservations.Any(r => ((r.Reservation_end.CompareTo(details.Reservation_start) > 0) && (r.Reservation_start.CompareTo(details.Reservation_end) < 0))))
                        {
                            MessageBox.Show("Reservation Conflict");
                            return false;
                        }
                        else
                        {
                            assetResult.First().Reservations.Add(details);
                            dbContext.SaveChanges();
                            return true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cannot add record, asset not found");
                        return false;
                    }
                }
                catch
                {
                    return false;
                }
            }
        }

        public static DataTable getAssetDataSource()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Asset ID", typeof(string));
            dataTable.Columns.Add("Asset Name", typeof(string));
            dataTable.Columns.Add("Asset Status", typeof(string));


            using (InventorydbEntities dbContext = new InventorydbEntities())
            {
                try
                {
                    IEnumerable<Asset> assetResult = from asset in dbContext.Assets
                                                     select asset;

                    if (assetResult.Any())
                    {
                        foreach (Asset item in assetResult)
                        {
                            dataTable.Rows.Add(item.Asset_id,item.Asset_name,item.asset_status);
                        }
                    }
                    
                }
                catch
                {
                    
                }
                return dataTable;
            }
        }

        public static DataTable getReservationDataSource()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Reservation ID", typeof(string));
            dataTable.Columns.Add("Reservation Start", typeof(string));
            dataTable.Columns.Add("Reservation End", typeof(string));


            using (InventorydbEntities dbContext = new InventorydbEntities())
            {
                try
                {
                    IEnumerable<Reservation> reservationResult = from asset in dbContext.Reservations
                                                     select asset;

                    if (reservationResult.Any())
                    {
                        foreach (Reservation item in reservationResult)
                        {
                            dataTable.Rows.Add(item.Reservation_id, item.Reservation_start, item.Reservation_end);
                        }
                    }

                }
                catch
                {

                }
                return dataTable;
            }
        }

        public static Asset GetAsset(string asset_id)
        {
            using (InventorydbEntities dbContext = new InventorydbEntities())
            {
                IEnumerable<Asset> result;
                try
                {

                    result = from asset in dbContext.Assets
                             where asset.Asset_id == asset_id
                             select asset;
                
                    if (result.Any())
                    {
                        return result.First();
                    }
                    else
                    {
                        return null;
                    }

                }
                catch
                {
                    MessageBox.Show("Unable to communicate with Database or Access is denied");
                    return null;
                }
            }
        }

        public static Reservation GetReservation(int reservation_id)
        {
            using (InventorydbEntities dbContext = new InventorydbEntities())
            {
                IEnumerable<Reservation> result;
                try
                {

                    result = from reservation in dbContext.Reservations
                             where reservation.Reservation_id == reservation_id
                             select reservation;

                    if (result.Any())
                    {
                        return result.First();
                    }
                    else
                    {
                        return null;
                    }

                }
                catch
                {
                    MessageBox.Show("Unable to communicate with Database or Access is denied");
                    return null;
                }
            }
        }


        public static void DeleteAsset(string asset_id)
        {
            using (InventorydbEntities dbContext = new InventorydbEntities())
            {
                IEnumerable<Asset> result;
                try
                {

                    result = from asset in dbContext.Assets
                         where asset.Asset_id == asset_id
                         select asset;

                if (result.Any())
                {
                    dbContext.Assets.Remove(result.First());
                    dbContext.SaveChanges();
                }

                }
                catch
                {
                    MessageBox.Show("Unable to communicate with Database or Access is denied");
                }
            }
        }

        public static void DeleteReservation(int reservationId)
        {
            using (InventorydbEntities dbContext = new InventorydbEntities())
            {
                IEnumerable<Reservation> result;
                try
                {

                    result = from reservation in dbContext.Reservations
                             where reservation.Reservation_id == reservationId
                             select reservation;

                    if (result.Any())
                    {
                        dbContext.Reservations.Remove(result.First());
                        dbContext.SaveChanges();
                    }

                }
                catch
                {
                    MessageBox.Show("Unable to communicate with Database or Access is denied");
                }
            }
        }

        public static void editAsset(Asset changed_Asset)
        {
            using (InventorydbEntities dbContext = new InventorydbEntities())
            {
                IEnumerable<Asset> result;
                try
                {

                    result = from asset in dbContext.Assets
                             where asset.Asset_id == changed_Asset.Asset_id
                             select asset;

                    if (result.Any())
                    {
                        result.First().Asset_name = changed_Asset.Asset_name;
                        result.First().Asset_description = changed_Asset.Asset_description;
                        dbContext.SaveChanges();
                            
                    }

                }
                catch
                {
                    MessageBox.Show("Unable to communicate with Database or Access is denied");
                }
            }
        }

        public static void editReservation(Reservation changed_Reservation)
        {
            using (InventorydbEntities dbContext = new InventorydbEntities())
            {
                IEnumerable<Reservation> result;
                try
                {

                    result = from reservation in dbContext.Reservations
                             where reservation.Reservation_id == changed_Reservation.Reservation_id
                             select reservation;

                    if (result.Any())
                    {
                        result.First().Reservation_start = changed_Reservation.Reservation_start;
                        result.First().Reservation_end = changed_Reservation.Reservation_end;
                        dbContext.SaveChanges();

                    }

                }
                catch
                {
                    MessageBox.Show("Unable to communicate with Database or Access is denied");
                }
            }
        }
    }        
}

