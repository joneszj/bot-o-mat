import { Gender } from "./Gender";

export interface CyborgViewModel {
  id: number;
  name: string;
  actoryType: string;
  gender: Gender;
  errands;
}
