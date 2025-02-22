/**
 * @param {number} x
 * @return {boolean}
 */
var isPalindrome = function(x) {

    if (x < 0) return false;
    
    const originalStr = x.toString();
    const reversedStr = originalStr.split('').reverse().join('');
    return originalStr === reversedStr;
};

console.log(isPalindrome(121));