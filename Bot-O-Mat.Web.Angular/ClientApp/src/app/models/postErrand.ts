export class PostErrandRequest {
  constructor(actorId: number, errand: number) {
    this.ActorId = actorId;
    this.ErrandType = errand;
  }

  ActorId: number;
  // TODO: consider enum
  ErrandType: number;
}

export interface PostErrandResponse {
  performingActorId: number;
  errand: string;
  completedSuccessfully: boolean;
  terminatedActorId?: number;
  terminatedActorName?: string;
  elapsedTime: number;
}
