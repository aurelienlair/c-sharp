class Hamming
  VERSION = 4
  def self.compute(strand1, strand2)
    if strand1.length != strand2.length
      raise ArgumentError.new(strand1.length.to_s + ' length is different than ' + strand2.length.to_s)
    end
    distance = 0
    strand1.chars.zip(strand2.chars) do |(char_a, char_b)|
       if char_a != char_b 
           distance += 1
       end
    end
  end
end