export class ErrorCodes {
    public static dbConnectionError: number = 100;
    public static dbQueryError: number = 101;
    public static dnNoDataFoundError: number = 102;
    public static WrongInputParamError: number = 103;
}

export class ErrorMessages {
    public static dbConnectionError: string = "Error: database server connection";
    public static dbQueryError: string = "Error: wrong database query";
    public static dnNoDataFoundError: string = "Error: no such data in database";
    public static WrongInputParamError: string = "Error: wrong request input param(s)";
}
