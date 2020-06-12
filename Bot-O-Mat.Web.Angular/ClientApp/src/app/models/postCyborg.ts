import { Gender } from "./Gender"

export class PostCyborgRequest {
  constructor(name: string, gender: Gender) {
    this.name = name;
    this.gender = gender;
  }
  name: string;
  gender: Gender;
}

export interface PostCyborgResponse {
  id: number;
  name: string;
  actorType: string;
  gender: Gender;
  // TODO: create type
  errands;
}
