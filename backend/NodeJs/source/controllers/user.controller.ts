import { Request, Response, NextFunction as Next } from "express";
import { SqlHelper } from "../helpers/sql.helpers";
import { UserService } from "../services/user.service";

const getUsers = async (req: Request, res: Response, next: Next) => {
    
  UserService.getUsers()
    .then((users) => {
        return res.status(200).json({
          types: users,
        });
    })
    .catch((error) => {
        return res.status(400).json({
          types: error,
        });
    })
  
    
};

const getUserById = async (req: Request, res: Response, next: Next) => {
  
    const currentId = req.params.id;
    
  UserService.getUserById(currentId)
    .then((user) => {
    
  })
  

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
