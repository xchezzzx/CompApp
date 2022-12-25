import { Request, Response, NextFunction as Next } from "express";
import { getUsersService } from "../services/user.services"
import { SqlHelper } from "../helpers/sql.helpers";

const getUsers = async (req: Request, res: Response, next: Next) => {
    
  //const users = await getUsersService(); 
  
  SqlHelper.OpenConnection() .then((connection) => {
    return res.status(200).json({
      connection
    });
  })
    .catch((errrror) => {
      return res.status(567).json({
      errrror
    })
  })
    
};

const getUserById = async (req: Request, res: Response, next: Next) => {
  
    const currentId = req.params.id;
    
    return res.status(200).json({
        get: `user by id:${currentId}`
    });
};

const updateUserById = async (req: Request, res: Response, next: Next) => {

    const currentId = req.params.id;

    return res.status(200).json({
      update: `user by id:${currentId}`
    });
};

const deleteUserById = async (req: Request, res: Response, next: Next) => {

    const currentId = req.params.id;

    return res.status(200).json({
      delete: `user by id:${currentId}`,
    });
};

const addUser = async (req: Request, res: Response, next: Next) => {
  

    return res.status(200).json({
      add: "user",
    });
};

export default {
  getUsers,
  getUserById,
  updateUserById,
  deleteUserById,
  addUser,
};
