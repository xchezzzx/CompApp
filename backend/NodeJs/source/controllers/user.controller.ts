import { Request, Response, NextFunction as Next } from "express";
import { getUsersService } from "../services/user.services"

const getUsers = async (req: Request, res: Response, next: Next) => {
    
    const users = await getUsersService(); 
    
    return res.status(200).json({
        "get": "users"
    });
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
