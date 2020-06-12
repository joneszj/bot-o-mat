export interface CompletedErrand {
  errandType: number;
  errandTypeName: string;
  errandStatus: number;
  timeToComplete: number;
}

export interface FailedErrand {
  errandType: number;
  errandTypeName: string;
  errandStatus: number;
  timeToComplete: number;
}

export interface ActorViewModel {
  self: any;
  id: number;
  image?: any;
  name: string;
  active: boolean;
  createdDate: string;
  modifiedDate: string;
  killedById?: any;
  completedErrands: CompletedErrand[];
  failedErrands: FailedErrand[];
  type: string;
}
