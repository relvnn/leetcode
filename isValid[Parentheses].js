var isValid = s => {
    let st = [];
    for (let i = 0, n = s.length; i < n; i++) {
      let c = s.charCodeAt(i);
      if (c === 40) st.push(41);
      else if (c === 91) st.push(93);
      else if (c === 123) st.push(125);
      else if (st.pop() !== c) return false;
    }
    return !st.length;
  };
  