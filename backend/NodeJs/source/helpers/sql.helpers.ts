import { Connection, Error, SqlClient, Query, ProcedureManager } from "msnodesqlv8";
import { DB_CONNECTION_STRING, UserQueries } from "../constants/sql.constants";

export class SqlHelper {
    static sql: SqlClient = require('msnodesqlv8');
  
    private static OpenConnection(): Promise<Connection>  {
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

    public static GetQueryArrayResult<T>(query: string): Promise<T[]> {
        return new Promise<T[]>((resolve, reject) => {
            this.OpenConnection()
                .then((connection: Connection) => {
                    connection.query(query, (queryError: Error | undefined, queryResult: T[] | undefined) => {
                        if (queryError) {
                            reject(queryError);
                        } else {
                            if (queryResult !== undefined) {
                                resolve(queryResult);
                            } else {
                                resolve([]);
                            }
                        }
                    });
                })
                .catch((connectionError) => {
                    reject(connectionError);
                })
        }) 
    }
}