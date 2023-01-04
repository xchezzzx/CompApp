import { Request } from "express";
import { ErrorHelper } from "../helpers/error.helper";
import { ErrorCodes, ErrorMessages } from "../constants/error.constants";
import { SystemError } from "../entities/error.entities";
import { UserInterface } from "../entities/user.entities";

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

    public static parseRequestBody(input: Request): UserInterface {
        return {
            id: input.body.id,
            first_name: input.body.first_name,
            last_name: input.body.last_name,
            email: input.body.email,
            password: input.body.password,
            role_id: input.body.role_id,
            team_id: input.body.team_id,
            points_summary: input.body.points_summary,
            date_create: input.body.date_create,
            date_update: input.body.date_update,
            user_create_id: input.body.user_create_id,
            user_update_id: input.body.user_update_id,
            status_id: input.body.status_id
        }
    }

}