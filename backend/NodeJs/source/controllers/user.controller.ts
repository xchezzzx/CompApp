import { Request, Response, NextFunction as Next } from "express";
import { SystemError } from "../entities/error.entities";
import { UserInterface } from "../entities/user.entities";
import { ErrorHelper } from "../helpers/error.helper";
import { RequestHelper } from "../helpers/request.helper";
import { SqlHelper } from "../helpers/sql.helper";
import { UserService } from "../services/user.service";

const getUsers = async (req: Request, res: Response, next: Next) => {

  UserService.getUsers()
    .then((users) => {
      return res.status(200).json(users);
    })
    .catch((error) => {
      return ErrorHelper.handleError(error, res)
    })


};

const getUserById = async (req: Request, res: Response, next: Next) => {

  const request: number | SystemError = RequestHelper.parseStringInputToNumber(req.params.id);

  if (typeof (request) === "number") {
    UserService.getUserById(request)
      .then((user) => {
        return res.status(200).json(user);
      })
      .catch((error) => {
        return ErrorHelper.handleError(error, res);
      });
  } else  {
    return ErrorHelper.handleError(request, res);
  }
  


};

const updateUserById = async (req: Request, res: Response, next: Next) => {

  const request: UserInterface = RequestHelper.parseRequestBody(req);
  
  console.log(request);
  
    UserService.updateUserById(request)
      .then((user) => {
        return res.status(200).json(user);
      })
      .catch((error) => {
        return ErrorHelper.handleError(error, res);
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
