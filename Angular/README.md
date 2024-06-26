# Lazy Image

## Temas de la sección
- @Inputs
- @Outputs
- Custom Components
- Validaciones
- Importación de módulos personalizados

> Pensar en compoenentes pequeños para reutilizar el codigo, estos son más faciles de mantener

# Lazy image

> Ordena las importaciones, primero los modulos y luego los componentes

```typescript
export class LazyImageComponent implements OnInit {
	@Input()
	public url!: string;
	@Input()
	public alt: string = ''; 
	
	public hasLoaded: boolean = false; 
	ngOnInit():void {
		if(!this.url) trow new Error('url property is required'); 
	}
	onLoad():void{
		setTimeout(()=>{
			this.hasLoader = true;
		}, 1000); 
	}
}	
```

```html
<div class="cualquier clase">
	<img
		[src]="url"
		[alt]="alt"
		class="cualquier calse"
		(load)="onLoad()"
		[ngStyle]="{ display: hasLoader ? '': 'none'}"	
	/>
	<img
		*ngIf="!isLoader"
		src="assets/img.svg"
		class="cualquier clase"
	/>
</div>
```
- Hay que ir a assets y colocar el .svg
```svg
<svg width="135" height="135" viewBox="0 0 135 135" xmlns="http://www.w3.org/2000/svg" fill="#fff">
    <path d="M67.447 58c5.523 0 10-4.477 10-10s-4.477-10-10-10-10 4.477-10 10 4.477 10 10 10zm9.448 9.447c0 5.523 4.477 10 10 10 5.522 0 10-4.477 10-10s-4.478-10-10-10c-5.523 0-10 4.477-10 10zm-9.448 9.448c-5.523 0-10 4.477-10 10 0 5.522 4.477 10 10 10s10-4.478 10-10c0-5.523-4.477-10-10-10zM58 67.447c0-5.523-4.477-10-10-10s-10 4.477-10 10 4.477 10 10 10 10-4.477 10-10z">
        <animateTransform
            attributeName="transform"
            type="rotate"
            from="0 67 67"
            to="-360 67 67"
            dur="2.5s"
            repeatCount="indefinite"/>
    </path>
    <path d="M28.19 40.31c6.627 0 12-5.374 12-12 0-6.628-5.373-12-12-12-6.628 0-12 5.372-12 12 0 6.626 5.372 12 12 12zm30.72-19.825c4.686 4.687 12.284 4.687 16.97 0 4.686-4.686 4.686-12.284 0-16.97-4.686-4.687-12.284-4.687-16.97 0-4.687 4.686-4.687 12.284 0 16.97zm35.74 7.705c0 6.627 5.37 12 12 12 6.626 0 12-5.373 12-12 0-6.628-5.374-12-12-12-6.63 0-12 5.372-12 12zm19.822 30.72c-4.686 4.686-4.686 12.284 0 16.97 4.687 4.686 12.285 4.686 16.97 0 4.687-4.686 4.687-12.284 0-16.97-4.685-4.687-12.283-4.687-16.97 0zm-7.704 35.74c-6.627 0-12 5.37-12 12 0 6.626 5.373 12 12 12s12-5.374 12-12c0-6.63-5.373-12-12-12zm-30.72 19.822c-4.686-4.686-12.284-4.686-16.97 0-4.686 4.687-4.686 12.285 0 16.97 4.686 4.687 12.284 4.687 16.97 0 4.687-4.685 4.687-12.283 0-16.97zm-35.74-7.704c0-6.627-5.372-12-12-12-6.626 0-12 5.373-12 12s5.374 12 12 12c6.628 0 12-5.373 12-12zm-19.823-30.72c4.687-4.686 4.687-12.284 0-16.97-4.686-4.686-12.284-4.686-16.97 0-4.687 4.686-4.687 12.284 0 16.97 4.686 4.687 12.284 4.687 16.97 0z">
        <animateTransform
            attributeName="transform"
            type="rotate"
            from="0 67 67"
            to="360 67 67"
            dur="8s"
            repeatCount="indefinite"/>
    </path>
</svg>
```

- Ir a Animate.css
	- Solo importar los estilos necesarios 

> Tarde o temprano siempre tocara refactorizar un codigo 

Un pipe recive tantos arreglos que se se necesiten 

# Loanding Component
- Se crea un Loading Spinner component
- Se declara y se exporta en el modulo 

