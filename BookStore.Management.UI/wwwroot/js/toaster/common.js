function showToaster(type, text, timeOut = 5000) {
    $.toast({
        heading: type,
        text: text,
        position: 'bottom-right',
        stack: false,
        icon: type === 'Information' ? 'info' : type.toLowerCase(),
        hidenAfter: timeOut
    })
}