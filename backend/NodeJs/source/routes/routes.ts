import express from "express";
import controller from "../controllers/controller";
const router = express.Router();

router.get("/posts", controller.getPosts);

export = router;
