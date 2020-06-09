export class Link {
  URL: string;
  Label: string;
  Order?: number;

  // TypeGaurd: https://www.typescriptlang.org/docs/handbook/advanced-types.html#type-guards-and-differentiating-types
  // I added this because when reading properties of a class (ex apiService w/ Object.values) I may want to restrict/filter on this type
  // A typegaurd is the accepted means of doing so as typeof and instance of are problematic
  static isLink(link): link is Link {
    return (link as Link).URL !== undefined && (link as Link).Label !== undefined;
  }
}
