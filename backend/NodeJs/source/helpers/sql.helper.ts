import { Connection, Error, SqlClient, Query, ProcedureManager } from "msnodesqlv8";
import { DB_CONNECTION_STRING, UserQueries } from "../constants/sql.constants";
import { ErrorHelper } from "./error.helper";
import { ErrorCodes, ErrorMessages } from "../constants/error.constants";
import { SystemError } from "../entities/error.entities";

export class SqlHelper {
  static sql: SqlClient = require("msnodesqlv8");

  private static OpenConnection(): Promise<Connection> {
    return new Promise<Connection>((resolve, reject) => {
      SqlHelper.sql.open(
        DB_CONNECTION_STRING,
        (connectionError: Error, connection: Connection) => {
          if (connectionError) {
            reject(ErrorHelper.parseError(ErrorMessages.dbConnectionError, ErrorCodes.dbConnectionError));
          } else {
            resolve(connection);
          }
        }
      );
    });
  }

  public static GetQueryArrayResult<T>(query: string, ...params: (number | string)[]): Promise<T[]> {
    return new Promise<T[]>((resolve, reject) => {
      this.OpenConnection()
        .then((connection: Connection) => {
          connection.query(query, params, (queryError: Error | undefined, queryResult: T[] | undefined) => {
            if (queryError) {
              reject(ErrorHelper.parseError(ErrorMessages.dbQueryError, ErrorCodes.dbQueryError));
            } else {
              if (queryResult !== undefined) {
                resolve(queryResult);
              } else {
                resolve([]);
              }
            }
          }
          );
        })
        .catch((error: SystemError) => {
          reject(error);
        });
    });
  }

  public static GetQuerySingleResult<T>(query: string, ...params: (number | string)[]): Promise<T> {
    return new Promise<T>((resolve, reject) => {
      this.OpenConnection()
        .then((connection: Connection) => {

          connection.query(query, params, (queryError: Error | undefined, queryResult: T[] | undefined) => {
            if (queryError) {
              reject(ErrorHelper.parseError(ErrorMessages.dbQueryError, ErrorCodes.dbQueryError));
            } else {
              if (queryResult !== undefined) {
                if (queryResult.length !== 0) {
                  resolve(queryResult[0]);
                } else {
                  reject(ErrorHelper.parseError(ErrorMessages.dnNoDataFoundError, ErrorCodes.dnNoDataFoundError));
                }
              }
            }
          })
        })

        .catch((error: SystemError) => {
          reject(error);
        });
    });
  }

  public static GetQueryNoResult(query: string, ...params: (number | string)[]): Promise<void> {
    return new Promise<void>((resolve, reject) => {
      this.OpenConnection()
        .then((connection: Connection) => {

          connection.query(query, params, (queryError: Error | undefined) => {
            if (queryError) {
              reject(ErrorHelper.parseError(ErrorMessages.dbQueryError, ErrorCodes.dbQueryError));
            } else {
              resolve();
            }
          });
          
        })

        .catch((error: SystemError) => {
          reject(error);
        });
    });
  }
}