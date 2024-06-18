const bod = new Bod();
class Header{
    private bool: Boolean = false;
    constructor(private title:string){
    }
    render():string{
       return `
            <header>
                <h1>${this.title}</h1>
                </header>
            ${bod.render()}
       ` 
    }
}