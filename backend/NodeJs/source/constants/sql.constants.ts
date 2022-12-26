export class UserQueries {
  //Test query
  public static getUsers: string = "SELECT * FROM [user]";
  public static getUserById: string = `SELECT * FROM [user] WHERE id = ?`;
  public static updateUserById: string = `UPDATE [user] SET status_id = ? WHERE id = ?`;
}
