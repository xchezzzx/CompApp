export class UserQueries {
  //Test query
  public static getUsers: string = "SELECT * FROM product";
  public static getUserById: string = `SELECT * FROM product WHERE id = ?`;
  //public static updateUserFirstName: string = "UPDATE product SET first_name = ? WHERE id = ?";
  public static updateUserById: string = `UPDATE product SET status_id = ? WHERE id = ?`;
}

//Test connection string
export const DB_CONNECTION_STRING: string = "server=MSI\\SQLEXPRESS;Database=masa-store;Trusted_Connection=Yes;Driver={ODBC Driver 17 for SQL Server}";