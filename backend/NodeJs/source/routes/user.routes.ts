import express from "express";
import userController from "../controllers/user.controller";
const router = express.Router();

router.get("/", userController.getUsers);
router.get("/:id", userController.getUserById);
router.put("/", userController.updateUserById);
router.delete("/:id", userController.deleteUserById);
router.post("/", userController.addUser);

export = router;
