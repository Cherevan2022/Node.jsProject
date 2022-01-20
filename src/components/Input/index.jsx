export const Input = ({text}) => {
    return (
        <div className="form-group">
  <fieldset>
    <input className="form-control text-center" id="readOnlyInput" type="text" placeholder={text} readonly=""/>
  </fieldset>
</div>
    )
}