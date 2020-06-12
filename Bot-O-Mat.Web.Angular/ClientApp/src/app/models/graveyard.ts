export interface KilledBy {
  id: number;
  name: string;
  actorType: number;
}

export interface GraveyardRecord {
  id: number;
  name: string;
  dateFallen: Date;
  killedBy: KilledBy;
}
