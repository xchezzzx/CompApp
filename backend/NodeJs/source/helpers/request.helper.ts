import { ErrorHelper } from "../helpers/error.helper";
import { ErrorCodes, ErrorMessages } from "../constants/error.constants";
import { SystemError } from "../entities/error.entities";

export class RequestHelper {

    public static parseStringInputToNumber(input: string): number | SystemError {
        
        const inputError: SystemError = ErrorHelper.parseError(ErrorMessages.WrongInputParamError, ErrorCodes.WrongInputParamError);
        
        if (isNaN(Number(input))) {
            return inputError;
        }

        if (input !== null && input !== undefined) {
            return parseInt(input);
        } else {
            return inputError;
        }
    }

}