
export interface UserInterface {
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