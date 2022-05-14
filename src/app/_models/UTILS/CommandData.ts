export class CommandData {
    Type: string;
    Data: any;
    Sender: string;

    constructor(type: string, data: any, sender: string){
        this.Data = data;
        this.Type = type;
        this.Sender = sender;
    }
}