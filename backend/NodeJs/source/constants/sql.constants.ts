export class UserQueries {
  //Test query
  public static getUsers: string = "SELECT * FROM product";
  public static getUserById: string = `SELECT * FROM product WHERE id = ?`;
}

//Test connection string
export const DB_CONNECTION_STRING: string = "server=MSI\\SQLEXPRESS;Database=masa-store;Trusted_Connection=Yes;Driver={ODBC Driver 17 for SQL Server}";