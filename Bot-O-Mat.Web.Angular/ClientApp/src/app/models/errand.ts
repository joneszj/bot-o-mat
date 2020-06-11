export interface Errand {
  errand: string;
  value: number;
}

export interface ErrandViewModel {
  // TODO: create enum | map
  errandType: number;
  errandTypeName: string;
  // TODO: create enum | map
  errandStatus: string;
  timeToComplete: number;
}
