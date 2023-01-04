import { ErrorCodes } from "../constants/error.constants";
import { SystemError } from "../entities/error.entities";
import { Response } from "express";


export class ErrorHelper {

    public static parseError(message: string, code: number): SystemError {
        const error: SystemError = {
            code: code,
            message: message
        }
        return error;
    }

    public static handleError(error: SystemError, response: Response): Response<any, Record<string, any>> {
        switch (error.code) {
            case ErrorCodes.dbConnectionError:
                return response.status(408).json({
                    errorMessage: error.message
                });
            case ErrorCodes.dbQueryError:
            case ErrorCodes.WrongInputParamError:
                return response.status(406).json({
                    errorMessage: error.message
                });
            case ErrorCodes.dnNoDataFoundError:
                return response.status(404).json({
                    errorMessage: error.message
                });
            default:
                return response.status(400).json({
                    errorMessage: error.message
                });
        }
    }
}