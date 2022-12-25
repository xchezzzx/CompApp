import { Connection, Error, SqlClient, Query, ProcedureManager } from "msnodesqlv8";
import { DB_CONNECTION_STRING, UserQueries } from "../constants/sql.constants";

export class SqlHelper {
    static sql: SqlClient = require('msnodesqlv8');
  
    public static OpenConnection(): Promise<Connection>  {
        return new Promise<Connection>((resolve, reject) =>  {
            SqlHelper.sql.open(DB_CONNECTION_STRING, (connectionError: Error, connection: Connection ) => {
                if (connectionError) {
                    //TODO:Error handling
                    reject(connectionError);
                }
                else {
                    resolve(connection);
                }
            })
        });
    };
}