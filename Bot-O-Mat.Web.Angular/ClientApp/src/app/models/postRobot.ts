import { RobotType } from "./robotType";

export class PostRobotRequest {
  constructor(name: string, type: RobotType) {
    this.name = name;
    this.nype = type;
  }
  name: string;
  nype: RobotType;
}

export class PostRobotResponse {
  id: number;
  name: string;
  actorType: string;
  gender: RobotType;
  // TODO: create type
  errands
}
