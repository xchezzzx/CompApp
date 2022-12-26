import { SqlHelper } from "../helpers/sql.helper";
import { UserQueries } from "../constants/sql.constants";
import { UserInterface } from "../entities/user.entities";
import { SystemError } from "../entities/error.entities";

interface LocalUserInterface {
    id: number;
    first_name: string;
    last_name: string;
    email: string;
    password: string;
    role_id: number;
    team_id: number;
    points_summary: number;
    date_create: Date;
    date_update: Date;
    user_create_id: number;
    user_update_id: number;
    status_id: number;
}




export class UserService {

    public static getUsers(): Promise<UserInterface[]> {
        return new Promise<UserInterface[]>((resolve, reject) => {

            const result: UserInterface[] = [];

            SqlHelper.GetQueryArrayResult<LocalUserInterface>(UserQueries.getUsers)

                .then((queryResult: LocalUserInterface[]) => {
                    queryResult.forEach((element) => {
                        result.push(this.parseLocalUserInterface(element));
                    });
                    resolve(result);
                })

                .catch((error: SystemError) => {
                    reject(error);
                })
        })
    };

    public static getUserById(id: number): Promise<UserInterface> {
        return new Promise<UserInterface>((resolve, reject) => {
            let result: UserInterface;

            SqlHelper.GetQuerySingleResult<LocalUserInterface>(UserQueries.getUserById, id)

                .then((queryResult: LocalUserInterface) => {
                    resolve(this.parseLocalUserInterface(queryResult));
                })
                .catch((error: SystemError) => {
                    reject(error);
                })
        })
    }

    public static updateUserById(user: UserInterface): Promise<UserInterface> {
        return new Promise<UserInterface>((resolve, reject) => {
            SqlHelper.GetQueryNoResult(UserQueries.updateUserById, user.status_id, user.id)
                .then(() => {
                    resolve(user);
                })
                .catch((error: SystemError) => {
                    reject(error);
                })
            
        })
    }

    private static parseLocalUserInterface(localUser: LocalUserInterface): UserInterface {
        return {
            id: localUser.id,
            first_name: localUser.first_name,
            last_name: localUser.last_name,
            email: localUser.email,
            password: localUser.password,
            role_id: localUser.role_id,
            team_id: localUser.team_id,
            points_summary: localUser.points_summary,
            date_create: localUser.date_create,
            date_update: localUser.date_update,
            user_create_id: localUser.user_create_id,
            user_update_id: localUser.user_update_id,
            status_id: localUser.status_id
        };
    }
}